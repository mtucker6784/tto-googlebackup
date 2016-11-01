namespace TuckerTech_GABackup_GUI
{
    partial class Preferences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preferences));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabSettings = new MetroFramework.Controls.MetroTabPage();
            this.txtDomainKey = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblReplaceDomain = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDefaultDomain = new System.Windows.Forms.Label();
            this.linkChange = new System.Windows.Forms.LinkLabel();
            this.lblSaveLoc = new System.Windows.Forms.Label();
            this.txtReplaceDomain = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDefaultDomain = new System.Windows.Forms.TextBox();
            this.txtSaveLocation = new System.Windows.Forms.TextBox();
            this.tabAdvanced = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnSaveMB = new System.Windows.Forms.Button();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtBiggerThan = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txtMB = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tipBiggerThan = new System.Windows.Forms.ToolTip(this.components);
            this.lblWhatsThis = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tabAdvanced.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(547, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 456);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(547, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stripLabel
            // 
            this.stripLabel.Name = "stripLabel";
            this.stripLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabSettings);
            this.metroTabControl1.Controls.Add(this.tabAdvanced);
            this.metroTabControl1.Location = new System.Drawing.Point(12, 27);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(527, 418);
            this.metroTabControl1.TabIndex = 19;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.lblWhatsThis);
            this.tabSettings.Controls.Add(this.txtDomainKey);
            this.tabSettings.Controls.Add(this.linkLabel1);
            this.tabSettings.Controls.Add(this.lblKey);
            this.tabSettings.Controls.Add(this.lblEmail);
            this.tabSettings.Controls.Add(this.btnCancel);
            this.tabSettings.Controls.Add(this.lblReplaceDomain);
            this.tabSettings.Controls.Add(this.btnSave);
            this.tabSettings.Controls.Add(this.lblDefaultDomain);
            this.tabSettings.Controls.Add(this.linkChange);
            this.tabSettings.Controls.Add(this.lblSaveLoc);
            this.tabSettings.Controls.Add(this.txtReplaceDomain);
            this.tabSettings.Controls.Add(this.txtEmail);
            this.tabSettings.Controls.Add(this.txtDefaultDomain);
            this.tabSettings.Controls.Add(this.txtSaveLocation);
            this.tabSettings.HorizontalScrollbarBarColor = true;
            this.tabSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.tabSettings.HorizontalScrollbarSize = 10;
            this.tabSettings.Location = new System.Drawing.Point(4, 38);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(519, 376);
            this.tabSettings.TabIndex = 0;
            this.tabSettings.Text = "Settings";
            this.tabSettings.VerticalScrollbarBarColor = true;
            this.tabSettings.VerticalScrollbarHighlightOnWheel = false;
            this.tabSettings.VerticalScrollbarSize = 10;
            // 
            // txtDomainKey
            // 
            this.txtDomainKey.Location = new System.Drawing.Point(185, 33);
            this.txtDomainKey.Name = "txtDomainKey";
            this.txtDomainKey.Size = new System.Drawing.Size(161, 20);
            this.txtDomainKey.TabIndex = 22;
            this.tipBiggerThan.SetToolTip(this.txtDomainKey, "Key downloaded when your domain service account was created");
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(352, 86);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(42, 13);
            this.linkLabel1.TabIndex = 30;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Browse";
            this.tipBiggerThan.SetToolTip(this.linkLabel1, "Browse to a specific location");
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.BackColor = System.Drawing.Color.Transparent;
            this.lblKey.Location = new System.Drawing.Point(95, 36);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(64, 13);
            this.lblKey.TabIndex = 17;
            this.lblKey.Text = "Domain Key";
            this.tipBiggerThan.SetToolTip(this.lblKey, "Key downloaded when your domain service account was created");
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Location = new System.Drawing.Point(95, 64);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(71, 13);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Service Email";
            this.tipBiggerThan.SetToolTip(this.lblEmail, "Email of service account (automatically created by Google in your API manager con" +
        "sole)");
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(271, 177);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblReplaceDomain
            // 
            this.lblReplaceDomain.AutoSize = true;
            this.lblReplaceDomain.BackColor = System.Drawing.Color.Transparent;
            this.lblReplaceDomain.Location = new System.Drawing.Point(95, 154);
            this.lblReplaceDomain.Name = "lblReplaceDomain";
            this.lblReplaceDomain.Size = new System.Drawing.Size(86, 13);
            this.lblReplaceDomain.TabIndex = 19;
            this.lblReplaceDomain.Text = "Replace Domain";
            this.tipBiggerThan.SetToolTip(this.lblReplaceDomain, "-OPTIONAL- Your Google / GSuite Domain (xyz.abc)");
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(185, 177);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDefaultDomain
            // 
            this.lblDefaultDomain.AutoSize = true;
            this.lblDefaultDomain.BackColor = System.Drawing.Color.Transparent;
            this.lblDefaultDomain.Location = new System.Drawing.Point(95, 128);
            this.lblDefaultDomain.Name = "lblDefaultDomain";
            this.lblDefaultDomain.Size = new System.Drawing.Size(80, 13);
            this.lblDefaultDomain.TabIndex = 20;
            this.lblDefaultDomain.Text = "Default Domain";
            this.tipBiggerThan.SetToolTip(this.lblDefaultDomain, "-OPTIONAL- Your AD Domain (abc.xyz)");
            // 
            // linkChange
            // 
            this.linkChange.AutoSize = true;
            this.linkChange.BackColor = System.Drawing.Color.Transparent;
            this.linkChange.Location = new System.Drawing.Point(352, 36);
            this.linkChange.Name = "linkChange";
            this.linkChange.Size = new System.Drawing.Size(42, 13);
            this.linkChange.TabIndex = 27;
            this.linkChange.TabStop = true;
            this.linkChange.Text = "Browse";
            this.tipBiggerThan.SetToolTip(this.linkChange, "Find your domain key");
            this.linkChange.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkChange_LinkClicked);
            // 
            // lblSaveLoc
            // 
            this.lblSaveLoc.AutoSize = true;
            this.lblSaveLoc.BackColor = System.Drawing.Color.Transparent;
            this.lblSaveLoc.Location = new System.Drawing.Point(95, 90);
            this.lblSaveLoc.Name = "lblSaveLoc";
            this.lblSaveLoc.Size = new System.Drawing.Size(47, 13);
            this.lblSaveLoc.TabIndex = 21;
            this.lblSaveLoc.Text = "Save to:";
            this.tipBiggerThan.SetToolTip(this.lblSaveLoc, "Location for backups.");
            // 
            // txtReplaceDomain
            // 
            this.txtReplaceDomain.Location = new System.Drawing.Point(185, 151);
            this.txtReplaceDomain.Name = "txtReplaceDomain";
            this.txtReplaceDomain.Size = new System.Drawing.Size(161, 20);
            this.txtReplaceDomain.TabIndex = 26;
            this.tipBiggerThan.SetToolTip(this.txtReplaceDomain, "-OPTIONAL- Your Google / GSuite Domain (xyz.abc)");
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(185, 57);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(161, 20);
            this.txtEmail.TabIndex = 23;
            this.tipBiggerThan.SetToolTip(this.txtEmail, "Email of service account (automatically created by Google in your API manager con" +
        "sole)");
            // 
            // txtDefaultDomain
            // 
            this.txtDefaultDomain.Location = new System.Drawing.Point(185, 125);
            this.txtDefaultDomain.Name = "txtDefaultDomain";
            this.txtDefaultDomain.Size = new System.Drawing.Size(161, 20);
            this.txtDefaultDomain.TabIndex = 25;
            this.tipBiggerThan.SetToolTip(this.txtDefaultDomain, "-OPTIONAL- Your AD Domain (abc.xyz)");
            // 
            // txtSaveLocation
            // 
            this.txtSaveLocation.Location = new System.Drawing.Point(185, 83);
            this.txtSaveLocation.Name = "txtSaveLocation";
            this.txtSaveLocation.Size = new System.Drawing.Size(161, 20);
            this.txtSaveLocation.TabIndex = 24;
            this.tipBiggerThan.SetToolTip(this.txtSaveLocation, "Location for backups.");
            // 
            // tabAdvanced
            // 
            this.tabAdvanced.Controls.Add(this.metroPanel2);
            this.tabAdvanced.Controls.Add(this.metroPanel1);
            this.tabAdvanced.HorizontalScrollbarBarColor = true;
            this.tabAdvanced.HorizontalScrollbarHighlightOnWheel = false;
            this.tabAdvanced.HorizontalScrollbarSize = 10;
            this.tabAdvanced.Location = new System.Drawing.Point(4, 38);
            this.tabAdvanced.Name = "tabAdvanced";
            this.tabAdvanced.Size = new System.Drawing.Size(519, 376);
            this.tabAdvanced.TabIndex = 1;
            this.tabAdvanced.Text = "Advanced";
            this.tabAdvanced.VerticalScrollbarBarColor = true;
            this.tabAdvanced.VerticalScrollbarHighlightOnWheel = false;
            this.tabAdvanced.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.btnSaveMB);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.txtBiggerThan);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 218);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(510, 142);
            this.metroPanel2.TabIndex = 20;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btnSaveMB
            // 
            this.btnSaveMB.Location = new System.Drawing.Point(217, 116);
            this.btnSaveMB.Name = "btnSaveMB";
            this.btnSaveMB.Size = new System.Drawing.Size(75, 23);
            this.btnSaveMB.TabIndex = 15;
            this.btnSaveMB.Text = "&Save";
            this.btnSaveMB.UseVisualStyleBackColor = true;
            this.btnSaveMB.Click += new System.EventHandler(this.btnSaveMB_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(345, 20);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(29, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "MB";
            // 
            // txtBiggerThan
            // 
            this.txtBiggerThan.BackColor = System.Drawing.SystemColors.ControlLight;
            // 
            // 
            // 
            this.txtBiggerThan.CustomButton.Image = null;
            this.txtBiggerThan.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.txtBiggerThan.CustomButton.Name = "";
            this.txtBiggerThan.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBiggerThan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBiggerThan.CustomButton.TabIndex = 1;
            this.txtBiggerThan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBiggerThan.CustomButton.UseSelectable = true;
            this.txtBiggerThan.CustomButton.Visible = false;
            this.txtBiggerThan.Lines = new string[0];
            this.txtBiggerThan.Location = new System.Drawing.Point(178, 16);
            this.txtBiggerThan.MaxLength = 32767;
            this.txtBiggerThan.Name = "txtBiggerThan";
            this.txtBiggerThan.PasswordChar = '\0';
            this.txtBiggerThan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBiggerThan.SelectedText = "";
            this.txtBiggerThan.SelectionLength = 0;
            this.txtBiggerThan.SelectionStart = 0;
            this.txtBiggerThan.ShortcutsEnabled = true;
            this.txtBiggerThan.Size = new System.Drawing.Size(161, 23);
            this.txtBiggerThan.TabIndex = 3;
            this.txtBiggerThan.UseSelectable = true;
            this.txtBiggerThan.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBiggerThan.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(16, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(152, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Ignore files bigger than: ";
            this.tipBiggerThan.SetToolTip(this.metroLabel1, "Ignore all files that are bigger than the specified size. \r\n\r\nTypically used to a" +
        "void downloading videos/movies from a user\'s drive\r\nwe probably don\'t want to sa" +
        "ve them anyway.");
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.txtMB);
            this.metroPanel1.Controls.Add(this.button1);
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(510, 213);
            this.metroPanel1.TabIndex = 19;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // txtMB
            // 
            this.txtMB.Enabled = false;
            this.txtMB.FormattingEnabled = true;
            this.txtMB.Items.AddRange(new object[] {
            "DOC",
            "GIF",
            "JPG",
            "LOG",
            "PDF",
            "PNG",
            "PPT",
            "TXT",
            "XLS"});
            this.txtMB.Location = new System.Drawing.Point(179, 26);
            this.txtMB.MultiColumn = true;
            this.txtMB.Name = "txtMB";
            this.txtMB.Size = new System.Drawing.Size(161, 154);
            this.txtMB.Sorted = true;
            this.txtMB.TabIndex = 1;
            this.txtMB.ThreeDCheckBoxes = true;
            this.tipBiggerThan.SetToolTip(this.txtMB, "Currently Disabled. All files will be downloaded.");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "&Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(90, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Backup the following files (DISABLED .. ALL FILES ALLOWED RIGHT NOW)";
            this.tipBiggerThan.SetToolTip(this.label1, "Currently Disabled. All files will be downloaded.");
            // 
            // tipBiggerThan
            // 
            this.tipBiggerThan.AutomaticDelay = 100;
            this.tipBiggerThan.AutoPopDelay = 5000;
            this.tipBiggerThan.InitialDelay = 100;
            this.tipBiggerThan.IsBalloon = true;
            this.tipBiggerThan.ReshowDelay = 20;
            this.tipBiggerThan.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tipBiggerThan.ToolTipTitle = "Advanced Info";
            // 
            // lblWhatsThis
            // 
            this.lblWhatsThis.AutoSize = true;
            this.lblWhatsThis.BackColor = System.Drawing.Color.Transparent;
            this.lblWhatsThis.Location = new System.Drawing.Point(353, 138);
            this.lblWhatsThis.Name = "lblWhatsThis";
            this.lblWhatsThis.Size = new System.Drawing.Size(65, 13);
            this.lblWhatsThis.TabIndex = 31;
            this.lblWhatsThis.Text = "What\'s this?";
            this.tipBiggerThan.SetToolTip(this.lblWhatsThis, resources.GetString("lblWhatsThis.ToolTip"));
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 478);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Preferences";
            this.Text = "Preferences";
            this.Activated += new System.EventHandler(this.Preferences_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Preferences_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Preferences_FormClosed);
            this.Load += new System.EventHandler(this.Preferences_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.tabAdvanced.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stripLabel;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tabSettings;
        private System.Windows.Forms.TextBox txtDomainKey;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblReplaceDomain;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDefaultDomain;
        private System.Windows.Forms.LinkLabel linkChange;
        private System.Windows.Forms.Label lblSaveLoc;
        private System.Windows.Forms.TextBox txtReplaceDomain;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDefaultDomain;
        private System.Windows.Forms.TextBox txtSaveLocation;
        private MetroFramework.Controls.MetroTabPage tabAdvanced;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.CheckedListBox txtMB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.Button btnSaveMB;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtBiggerThan;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ToolTip tipBiggerThan;
        private System.Windows.Forms.Label lblWhatsThis;
    }
}