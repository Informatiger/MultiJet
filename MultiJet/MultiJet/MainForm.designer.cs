namespace MultiJet
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lvMessages = new System.Windows.Forms.ListView();
            this.colHeadUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSendMessage = new MetroFramework.Controls.MetroButton();
            this.btnConnectToServer = new MetroFramework.Controls.MetroButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbEmoji = new MetroFramework.Controls.MetroComboBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.tbServerIP = new MultiJet.TextBoxWithPlaceHolder();
            this.tbUsername = new MultiJet.TextBoxWithPlaceHolder();
            this.tbMessage = new MultiJet.TextBoxWithPlaceHolder();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvMessages
            // 
            this.lvMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeadUsername,
            this.colHeadMessage,
            this.colHeadTime});
            this.lvMessages.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvMessages.FullRowSelect = true;
            this.lvMessages.GridLines = true;
            this.lvMessages.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvMessages.Location = new System.Drawing.Point(20, 85);
            this.lvMessages.Margin = new System.Windows.Forms.Padding(4);
            this.lvMessages.MultiSelect = false;
            this.lvMessages.Name = "lvMessages";
            this.lvMessages.Size = new System.Drawing.Size(552, 270);
            this.lvMessages.TabIndex = 1;
            this.lvMessages.UseCompatibleStateImageBehavior = false;
            this.lvMessages.View = System.Windows.Forms.View.Details;
            this.lvMessages.ItemActivate += new System.EventHandler(this.lvMessages_ItemActivate);
            // 
            // colHeadUsername
            // 
            this.colHeadUsername.Text = "Username";
            this.colHeadUsername.Width = 122;
            // 
            // colHeadMessage
            // 
            this.colHeadMessage.Text = "Message";
            this.colHeadMessage.Width = 350;
            // 
            // colHeadTime
            // 
            this.colHeadTime.Text = "Time";
            this.colHeadTime.Width = 68;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendMessage.Location = new System.Drawing.Point(477, 363);
            this.btnSendMessage.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(96, 32);
            this.btnSendMessage.TabIndex = 5;
            this.btnSendMessage.Text = "Send";
            this.btnSendMessage.UseSelectable = true;
            this.btnSendMessage.UseStyleColors = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // btnConnectToServer
            // 
            this.btnConnectToServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnectToServer.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnConnectToServer.Location = new System.Drawing.Point(448, 55);
            this.btnConnectToServer.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnectToServer.Name = "btnConnectToServer";
            this.btnConnectToServer.Size = new System.Drawing.Size(124, 22);
            this.btnConnectToServer.TabIndex = 8;
            this.btnConnectToServer.Text = "Connect";
            this.btnConnectToServer.UseSelectable = true;
            this.btnConnectToServer.UseStyleColors = true;
            this.btnConnectToServer.Click += new System.EventHandler(this.btnConnectToServer_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipTitle = "New message arrived";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Jet";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 26);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // cbEmoji
            // 
            this.cbEmoji.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbEmoji.Enabled = false;
            this.cbEmoji.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmoji.FormattingEnabled = true;
            this.cbEmoji.ItemHeight = 23;
            this.cbEmoji.Items.AddRange(new object[] {
            "",
            "🤣",
            "☺",
            "🙂",
            "🙃",
            "🤡",
            "🤠",
            "🙁",
            "☹",
            "😣",
            "😫",
            "😩",
            "😤",
            "😠",
            "😡",
            "😶",
            "😯",
            "😦",
            "😧",
            "😮",
            "😲",
            "😵",
            "😳",
            "😱",
            "😨",
            "😰",
            "😢",
            "😥",
            "🤤",
            "😭",
            "😪",
            "😴",
            "🙄",
            "😪",
            "😴",
            "🙄",
            "🤥",
            "😬",
            "🤢",
            "🤧",
            "😷",
            "👿",
            "👹",
            "👺",
            "💩",
            "👻",
            "💀",
            "☠",
            "👽",
            "👾",
            "🎃",
            "😺",
            "😸",
            "😹",
            "😻",
            "😼",
            "😽",
            "🙀",
            "😿",
            "😾",
            "👐",
            "🙌",
            "👏",
            "🙏",
            "👍",
            "👎",
            "👊",
            "👌",
            "👈",
            "👉",
            "👆",
            "👇",
            "🖖",
            "👋",
            "💪",
            "🖕"});
            this.cbEmoji.Location = new System.Drawing.Point(20, 363);
            this.cbEmoji.Margin = new System.Windows.Forms.Padding(4);
            this.cbEmoji.Name = "cbEmoji";
            this.cbEmoji.Size = new System.Drawing.Size(71, 29);
            this.cbEmoji.TabIndex = 10;
            this.cbEmoji.UseSelectable = true;
            this.cbEmoji.UseStyleColors = true;
            this.cbEmoji.SelectedIndexChanged += new System.EventHandler(this.cbEmoji_SelectedIndexChanged);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tbServerIP
            // 
            this.tbServerIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tbServerIP.CustomButton.Image = null;
            this.tbServerIP.CustomButton.Location = new System.Drawing.Point(190, 2);
            this.tbServerIP.CustomButton.Name = "";
            this.tbServerIP.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.tbServerIP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbServerIP.CustomButton.TabIndex = 1;
            this.tbServerIP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbServerIP.CustomButton.UseSelectable = true;
            this.tbServerIP.CustomButton.Visible = false;
            this.tbServerIP.Lines = new string[0];
            this.tbServerIP.Location = new System.Drawing.Point(230, 55);
            this.tbServerIP.Margin = new System.Windows.Forms.Padding(4);
            this.tbServerIP.MaxLength = 32767;
            this.tbServerIP.Name = "tbServerIP";
            this.tbServerIP.PasswordChar = '\0';
            this.tbServerIP.PlaceHolderText = "Server IP";
            this.tbServerIP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbServerIP.SelectedText = "";
            this.tbServerIP.SelectionLength = 0;
            this.tbServerIP.SelectionStart = 0;
            this.tbServerIP.ShortcutsEnabled = true;
            this.tbServerIP.Size = new System.Drawing.Size(210, 22);
            this.tbServerIP.TabIndex = 4;
            this.tbServerIP.UseSelectable = true;
            this.tbServerIP.UseStyleColors = true;
            this.tbServerIP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbServerIP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbServerIP.Enter += new System.EventHandler(this.tbServerIP_Enter);
            this.tbServerIP.Leave += new System.EventHandler(this.tbServerIP_Leave);
            // 
            // tbUsername
            // 
            // 
            // 
            // 
            this.tbUsername.CustomButton.Image = null;
            this.tbUsername.CustomButton.Location = new System.Drawing.Point(182, 2);
            this.tbUsername.CustomButton.Name = "";
            this.tbUsername.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.tbUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbUsername.CustomButton.TabIndex = 1;
            this.tbUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbUsername.CustomButton.UseSelectable = true;
            this.tbUsername.CustomButton.Visible = false;
            this.tbUsername.Lines = new string[0];
            this.tbUsername.Location = new System.Drawing.Point(20, 55);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(4);
            this.tbUsername.MaxLength = 32767;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PasswordChar = '\0';
            this.tbUsername.PlaceHolderText = "Username";
            this.tbUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbUsername.SelectedText = "";
            this.tbUsername.SelectionLength = 0;
            this.tbUsername.SelectionStart = 0;
            this.tbUsername.ShortcutsEnabled = true;
            this.tbUsername.Size = new System.Drawing.Size(202, 22);
            this.tbUsername.TabIndex = 2;
            this.tbUsername.UseSelectable = true;
            this.tbUsername.UseStyleColors = true;
            this.tbUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbUsername.Enter += new System.EventHandler(this.tbUsername_Enter);
            this.tbUsername.Leave += new System.EventHandler(this.tbUsername_Leave);
            // 
            // tbMessage
            // 
            this.tbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tbMessage.CustomButton.Image = null;
            this.tbMessage.CustomButton.Location = new System.Drawing.Point(346, 2);
            this.tbMessage.CustomButton.Name = "";
            this.tbMessage.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbMessage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbMessage.CustomButton.TabIndex = 1;
            this.tbMessage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbMessage.CustomButton.UseSelectable = true;
            this.tbMessage.CustomButton.Visible = false;
            this.tbMessage.Enabled = false;
            this.tbMessage.Lines = new string[0];
            this.tbMessage.Location = new System.Drawing.Point(99, 366);
            this.tbMessage.Margin = new System.Windows.Forms.Padding(4);
            this.tbMessage.MaxLength = 1024;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.PasswordChar = '\0';
            this.tbMessage.PlaceHolderText = "Enter to Send";
            this.tbMessage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbMessage.SelectedText = "";
            this.tbMessage.SelectionLength = 0;
            this.tbMessage.SelectionStart = 0;
            this.tbMessage.ShortcutsEnabled = true;
            this.tbMessage.Size = new System.Drawing.Size(370, 26);
            this.tbMessage.TabIndex = 0;
            this.tbMessage.UseSelectable = true;
            this.tbMessage.UseStyleColors = true;
            this.tbMessage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbMessage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbMessage.Enter += new System.EventHandler(this.tbMessage_Enter);
            this.tbMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMessage_KeyDown);
            this.tbMessage.Leave += new System.EventHandler(this.tbMessage_Leave);
            // 
            // MainForm
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.BackImagePadding = new System.Windows.Forms.Padding(5);
            this.BackLocation = MetroFramework.Forms.BackLocation.TopRight;
            this.ClientSize = new System.Drawing.Size(597, 407);
            this.Controls.Add(this.cbEmoji);
            this.Controls.Add(this.btnConnectToServer);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.tbServerIP);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lvMessages);
            this.Controls.Add(this.tbMessage);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(597, 404);
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Jet";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBoxWithPlaceHolder tbMessage;
        private System.Windows.Forms.ListView lvMessages;
        private TextBoxWithPlaceHolder tbUsername;
        private System.Windows.Forms.ColumnHeader colHeadUsername;
        private System.Windows.Forms.ColumnHeader colHeadMessage;
        private System.Windows.Forms.ColumnHeader colHeadTime;
        private TextBoxWithPlaceHolder tbServerIP;
        private MetroFramework.Controls.MetroButton btnSendMessage;
        private MetroFramework.Controls.MetroButton btnConnectToServer;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private MetroFramework.Controls.MetroComboBox cbEmoji;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}

