using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace MultiJet
{
    struct MESSAGE_TYPE
    {
        public const string TEXT = "TEXT";
        public const string URL = "URL";
    }

    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        StringBuilder messageBuilder = new StringBuilder();

        public bool ReallyClose { get; set; }
        public bool AllowSendMessage { get; set; }
        SimpleTCP.SimpleTcpClient client;

        public MainForm(String[] args)
        {
            InitializeComponent();

            client = new SimpleTCP.SimpleTcpClient();
            client.DataReceived += Client_DataReceived;

            tbMessage.Text = tbMessage.PlaceHolderText;
            tbUsername.Text = tbUsername.PlaceHolderText;
            tbServerIP.Text = tbServerIP.PlaceHolderText;
            ReallyClose = false;
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            foreach (var thisMessage in e.MessageString.Trim().Split('\u0013'))
            {
                var msg = ReplaceNonPrintableCharacters(thisMessage);
                if (String.IsNullOrEmpty(msg)) return;

                var cmd = msg.Substring(0, 5);

                var Array = new String[3];
                ListViewItem item;
                switch (cmd)
                {
                    case "!INF:":
                        Array[0] = "INFO";
                        Array[1] = ReplaceNonPrintableCharacters(msg.Substring(5).Trim());
                        Array[2] = DateTime.Now.ToShortTimeString();

                        item = new ListViewItem(Array);
                        item.Tag = "INFO";
                        break;
                    case "!DBG:":
                        Array[0] = "DEBUG";
                        Array[1] = ReplaceNonPrintableCharacters(msg.Substring(5).Trim());
                        Array[2] = DateTime.Now.ToShortTimeString();

                        item = new ListViewItem(Array);
                        item.Tag = "DEBUG";
                        break;
                    case "!ERR:":
                        Array[0] = "ERROR";
                        Array[1] = ReplaceNonPrintableCharacters(msg.Substring(5).Trim());
                        Array[2] = DateTime.Now.ToShortTimeString();

                        item = new ListViewItem(Array);
                        item.Tag = "ERROR";
                        break;
                    default:
                        int firstColon = msg.IndexOf(':');
                        var message = msg.Substring(firstColon + 1);

                        Array[0] = msg.Substring(0, firstColon);
                        Array[1] = ReplaceNonPrintableCharacters(message.Trim());
                        Array[2] = DateTime.Now.ToShortTimeString();

                        item = new ListViewItem(Array);
                        if (IsUrlValid(message))
                            item.Tag = MESSAGE_TYPE.URL;
                        else
                            item.Tag = MESSAGE_TYPE.TEXT;
                        if (!Visible || this.WindowState.Equals(FormWindowState.Minimized))
                            Notify(message);
                        break;
                }
                AddItem(item);
            }
            
        }

        private void tbUsername_Enter(object sender, EventArgs e)
        {
            if (tbUsername.Text == tbUsername.PlaceHolderText)
                tbUsername.Text = string.Empty;
        }

        private void tbUsername_Leave(object sender, EventArgs e)
        {
            if (tbUsername.Text == string.Empty)
                tbUsername.Text = tbUsername.PlaceHolderText;
        }

        private void tbServerIP_Enter(object sender, EventArgs e)
        {
            if (tbServerIP.Text == tbServerIP.PlaceHolderText)
                tbServerIP.Text = string.Empty;
        }

        private void tbServerIP_Leave(object sender, EventArgs e)
        {
            if (tbServerIP.Text == string.Empty)
                tbServerIP.Text = tbServerIP.PlaceHolderText;
        }

        private void tbMessage_Enter(object sender, EventArgs e)
        {
            if (tbMessage.Text == tbMessage.PlaceHolderText)
                tbMessage.Text = string.Empty;
        }

        private void tbMessage_Leave(object sender, EventArgs e)
        {
            if (tbMessage.Text == string.Empty)
                tbMessage.Text = tbMessage.PlaceHolderText;
        }

        private void tbMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && AllowSendMessage && (!String.IsNullOrEmpty(tbMessage.Text)))
            {
                foreach (var msg in tbMessage.Text.Split('\n'))
                {
                    messageBuilder.AppendLine(msg);
                }
                SendTextMessage(messageBuilder.ToString().Trim());
                messageBuilder.Clear();
            }
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            if (AllowSendMessage && (!String.IsNullOrEmpty(tbMessage.Text)))
                SendTextMessage(tbMessage.Text);
        }

        /// <summary>
        /// Method to send messages
        /// </summary>
        /// <param name="message">message content</param>
        private void SendTextMessage(String message)
        {
            if (String.IsNullOrEmpty(message))
                return;

            try
            {
                client.WriteLine(ReplaceNonPrintableCharacters(message));
                tbMessage.Text = String.Empty;
                tbMessage.Focus();
            }
            catch (Exception ex)
            {
                ShowAlert(ex.ToString());
            }
        }

        /// <summary>
        /// Connetcting to your friends server
        /// </summary>
        private void ConnectToServer()
        {
            try
            {
                client.Connect(tbServerIP.Text, 31415);
                client.WriteLine(tbUsername.Text);

                AllowSendMessage = true;
                tbMessage.Focus();
            }
            catch (Exception ex)
            {
                ShowAlert(ex.ToString());
            }
        }

        /// <summary>
        /// Shows a messagebox
        /// </summary>
        /// <param name="value">message content</param>
        public void ShowAlert(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(ShowAlert), new object[] { value });
                return;
            }
            MetroFramework.MetroMessageBox.Show(this, value);
        }

        /// <summary>
        /// calls the NotifyMessage method (by invoke)
        /// </summary>
        /// <param name="message">Notify message</param>
        public void Notify(String message)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<String>(NotifyMessage), new object[] { message });
                return;
            }
            NotifyMessage(message);
        }

        /// <summary>
        /// shows a toast notification
        /// </summary>
        /// <param name="message">content of the toast notification</param>
        public void NotifyMessage(String message)
        {
            notifyIcon1.BalloonTipText = message;
            notifyIcon1.ShowBalloonTip(5000);
        }

        /// <summary>
        /// adds item to ListView (by invoke)
        /// </summary>
        /// <param name="itm">Item</param>
        public void AddItem(ListViewItem itm)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<ListViewItem>(AddItem), new object[] { itm });
                return;
            }

            switch (itm.Tag.ToString())
            {
                case "ERROR":
                    itm.ForeColor = Color.DarkRed;
                    break;
                default:
                    break;
            }

            lvMessages.Items.Add(itm);

            var x = lvMessages.Items.Count - 1;
            lvMessages.EnsureVisible(x);
        }

        /// <summary>
        /// check if url is vaild
        /// </summary>
        /// <param name="url">URL</param>
        /// <returns>URL valid?</returns>
        private bool IsUrlValid(string url)
        {
            string pattern = @"^(http|https|file|ftp|)\://|[a-zA-Z0-9\-\.]+\.[a-zA-Z](:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&amp;%\$#\=~])*[^\.\,\)\(\s]$";
            Regex reg = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            return reg.IsMatch(url);
        }

        /// <summary>
        /// removes non-printable characters
        /// </summary>
        /// <param name="s">text</param>
        /// <returns>text without non-printable characters</returns>
        string ReplaceNonPrintableCharacters(string s)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                var character = s[i];
                if (((byte)character) >= 32)
                    result.Append(character);
            }
            return result.ToString();
        }

        private void btnConnectToServer_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbUsername.Text))
            {
                ShowAlert("Please enter a username");
                return;
            }
            if (String.IsNullOrEmpty(tbServerIP.Text))
            {
                ShowAlert("Please enter a server");
                return;
            }

            ConnectToServer();
            btnConnectToServer.Enabled = false;
            tbServerIP.ReadOnly = true;
            tbUsername.ReadOnly = true;
            tbMessage.Enabled = true;
            cbEmoji.Enabled = true;
        }

        private void lvMessages_ItemActivate(object sender, EventArgs e)
        {
            try
            {
                if (lvMessages.SelectedItems[0].Tag.Equals("URL"))
                {
                    var url = lvMessages.SelectedItems[0].SubItems[1].Text;

                    if (MessageBox.Show("Open " + url + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        Process.Start("explorer.exe", url);
                }
                else if (lvMessages.SelectedItems[0].Tag.Equals("TEXT"))
                {
                    var tView = new MessageView(lvMessages.SelectedItems[0].SubItems[1].Text);
                    tView.Show();
                }
            }
            catch (Exception ex)
            {
                ShowAlert(ex.ToString());
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ReallyClose)
            {
                Hide();
                e.Cancel = true;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReallyClose = true;
            Close();
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            if (!Visible)
            {
                Show();
            }
        }

        private void cbEmoji_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEmoji.SelectedIndex > 0)
            {
                if (tbMessage.Text == tbMessage.PlaceHolderText)
                    tbMessage.Text = String.Empty;
                tbMessage.Text += cbEmoji.SelectedItem.ToString();
                tbMessage.Focus();
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!Visible)
                {
                    Show();
                }
            }
        }
    }
}
