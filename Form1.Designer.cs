namespace TuckerTech_GABackup_GUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.bgW = new System.ComponentModel.BackgroundWorker();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.bgLDAP = new System.ComponentModel.BackgroundWorker();
            this.bgSkipFile = new System.ComponentModel.BackgroundWorker();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripButton();
            this.conMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.conRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.conRefreshRight = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.conUserMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panel4 = new MetroFramework.Controls.MetroPanel();
            this.btnPref = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.buttonAdv1 = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabBackup = new System.Windows.Forms.TabPage();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnSkipUser = new System.Windows.Forms.Button();
            this.lblProgresslbl = new MetroFramework.Controls.MetroLabel();
            this.lblCurrentToken = new MetroFramework.Controls.MetroLabel();
            this.txtCurrentToken = new System.Windows.Forms.TextBox();
            this.lblPrevToken = new MetroFramework.Controls.MetroLabel();
            this.proUser = new MetroFramework.Controls.MetroProgressBar();
            this.txtPrevToken = new System.Windows.Forms.TextBox();
            this.lblCurrentUser = new MetroFramework.Controls.MetroLabel();
            this.txtCurrentUser = new System.Windows.Forms.TextBox();
            this.lstBackupUsers = new MetroFramework.Controls.MetroListView();
            this.colUsers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabRestore = new System.Windows.Forms.TabPage();
            this.tabControlAdv1 = new System.Windows.Forms.TabControl();
            this.tabPageAdv1 = new System.Windows.Forms.TabPage();
            this.lstFiles = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabEmail = new System.Windows.Forms.TabPage();
            this.lblNA = new MetroFramework.Controls.MetroLabel();
            this.lstGmail = new MetroFramework.Controls.MetroListView();
            this.colEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSent = new MetroFramework.Controls.MetroLabel();
            this.lblInbox = new MetroFramework.Controls.MetroLabel();
            this.lblUnread = new MetroFramework.Controls.MetroLabel();
            this.lblUserTitle = new MetroFramework.Controls.MetroLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblFound = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miniToolStrip = new System.Windows.Forms.MenuStrip();
            this.notifyTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.conNotifyTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bgwAD = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1.SuspendLayout();
            this.conMenuStrip.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.tabBackup.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabRestore.SuspendLayout();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            this.tabEmail.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.conNotifyTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripLabel,
            this.statusStripLabel1,
            this.lblFile});
            this.statusStrip1.Location = new System.Drawing.Point(1, 644);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(812, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stripLabel
            // 
            this.stripLabel.Name = "stripLabel";
            this.stripLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStripLabel1
            // 
            this.statusStripLabel1.Name = "statusStripLabel1";
            this.statusStripLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // lblFile
            // 
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(0, 17);
            // 
            // bgW
            // 
            this.bgW.WorkerReportsProgress = true;
            this.bgW.WorkerSupportsCancellation = true;
            this.bgW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgW_DoWork);
            this.bgW.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgW_ProgressChanged);
            this.bgW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgW_RunWorkerCompleted);
            // 
            // bgLDAP
            // 
            this.bgLDAP.WorkerReportsProgress = true;
            this.bgLDAP.WorkerSupportsCancellation = true;
            this.bgLDAP.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgLDAP_DoWork);
            this.bgLDAP.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgLDAP_RunWorkerCompleted);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(65, 44);
            this.toolStripLabel1.Text = "Browse";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel2.Image")));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(51, 44);
            this.toolStripLabel2.Text = "Start";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel3.Image")));
            this.toolStripLabel3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(53, 44);
            this.toolStripLabel3.Text = "LDAP";
            this.toolStripLabel3.Click += new System.EventHandler(this.toolStripLabel3_Click);
            // 
            // conMenuStrip
            // 
            this.conMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conRestore,
            this.conRefreshRight});
            this.conMenuStrip.Name = "conMenuStrip";
            this.conMenuStrip.Size = new System.Drawing.Size(161, 48);
            // 
            // conRestore
            // 
            this.conRestore.Name = "conRestore";
            this.conRestore.Size = new System.Drawing.Size(160, 22);
            this.conRestore.Text = "Restore Selected";
            this.conRestore.Click += new System.EventHandler(this.conRestore_Click);
            // 
            // conRefreshRight
            // 
            this.conRefreshRight.Name = "conRefreshRight";
            this.conRefreshRight.Size = new System.Drawing.Size(160, 22);
            this.conRefreshRight.Text = "Refresh";
            this.conRefreshRight.Click += new System.EventHandler(this.conRefreshRight_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conUserMenu});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(114, 26);
            // 
            // conUserMenu
            // 
            this.conUserMenu.Name = "conUserMenu";
            this.conUserMenu.Size = new System.Drawing.Size(113, 22);
            this.conUserMenu.Text = "Refresh";
            this.conUserMenu.Click += new System.EventHandler(this.conUserMenu_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(69, 40);
            this.toolStripButton1.Text = "Settings";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.btnPref);
            this.panel4.Controls.Add(this.btnStart);
            this.panel4.Controls.Add(this.buttonAdv1);
            this.panel4.Controls.Add(this.btnBrowse);
            this.panel4.Controls.Add(this.txtFile);
            this.panel4.HorizontalScrollbarBarColor = true;
            this.panel4.HorizontalScrollbarHighlightOnWheel = false;
            this.panel4.HorizontalScrollbarSize = 10;
            this.panel4.Location = new System.Drawing.Point(3, 26);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(803, 72);
            this.panel4.TabIndex = 55;
            this.panel4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.panel4.UseCustomBackColor = true;
            this.panel4.UseCustomForeColor = true;
            this.panel4.UseStyleColors = true;
            this.panel4.VerticalScrollbarBarColor = true;
            this.panel4.VerticalScrollbarHighlightOnWheel = false;
            this.panel4.VerticalScrollbarSize = 10;
            // 
            // btnPref
            // 
            this.btnPref.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPref.Image = ((System.Drawing.Image)(resources.GetObject("btnPref.Image")));
            this.btnPref.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPref.Location = new System.Drawing.Point(390, 3);
            this.btnPref.Name = "btnPref";
            this.btnPref.Size = new System.Drawing.Size(123, 38);
            this.btnPref.TabIndex = 45;
            this.btnPref.Text = "Preferences";
            this.btnPref.UseVisualStyleBackColor = false;
            this.btnPref.Click += new System.EventHandler(this.btnPref_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Location = new System.Drawing.Point(261, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(123, 38);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start backup!";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.buttonAdv2_Click);
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAdv1.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdv1.Image")));
            this.buttonAdv1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv1.Location = new System.Drawing.Point(132, 3);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(123, 38);
            this.buttonAdv1.TabIndex = 1;
            this.buttonAdv1.Text = "LDAP";
            this.buttonAdv1.UseVisualStyleBackColor = false;
            this.buttonAdv1.Click += new System.EventHandler(this.buttonAdv1_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBrowse.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowse.Image")));
            this.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowse.Location = new System.Drawing.Point(3, 3);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(123, 38);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse for file";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFile
            // 
            this.txtFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFile.Enabled = false;
            this.txtFile.Location = new System.Drawing.Point(3, 47);
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(381, 20);
            this.txtFile.TabIndex = 44;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.metroTabControl1);
            this.panel3.Location = new System.Drawing.Point(-1, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(812, 538);
            this.panel3.TabIndex = 37;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl1.CausesValidation = false;
            this.metroTabControl1.Controls.Add(this.tabBackup);
            this.metroTabControl1.Controls.Add(this.tabRestore);
            this.metroTabControl1.Location = new System.Drawing.Point(7, 5);
            this.metroTabControl1.Multiline = true;
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(800, 531);
            this.metroTabControl1.TabIndex = 41;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabBackup
            // 
            this.tabBackup.Controls.Add(this.txtLog);
            this.tabBackup.Controls.Add(this.panel1);
            this.tabBackup.Controls.Add(this.lstBackupUsers);
            this.tabBackup.Location = new System.Drawing.Point(4, 41);
            this.tabBackup.Name = "tabBackup";
            this.tabBackup.Size = new System.Drawing.Size(792, 486);
            this.tabBackup.TabIndex = 0;
            this.tabBackup.Text = "Backup Files";
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.BackColor = System.Drawing.Color.White;
            this.txtLog.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLog.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtLog.Location = new System.Drawing.Point(177, 184);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(615, 302);
            this.txtLog.TabIndex = 57;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.metroButton1);
            this.panel1.Controls.Add(this.btnSkipUser);
            this.panel1.Controls.Add(this.lblProgresslbl);
            this.panel1.Controls.Add(this.lblCurrentToken);
            this.panel1.Controls.Add(this.txtCurrentToken);
            this.panel1.Controls.Add(this.lblPrevToken);
            this.panel1.Controls.Add(this.proUser);
            this.panel1.Controls.Add(this.txtPrevToken);
            this.panel1.Controls.Add(this.lblCurrentUser);
            this.panel1.Controls.Add(this.txtCurrentUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(177, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 178);
            this.panel1.TabIndex = 56;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(19, 152);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 52;
            this.metroButton1.Text = "Skip &File";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Visible = false;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnSkipUser
            // 
            this.btnSkipUser.Location = new System.Drawing.Point(112, 152);
            this.btnSkipUser.Name = "btnSkipUser";
            this.btnSkipUser.Size = new System.Drawing.Size(75, 23);
            this.btnSkipUser.TabIndex = 51;
            this.btnSkipUser.Text = "&Skip User";
            this.btnSkipUser.UseVisualStyleBackColor = true;
            this.btnSkipUser.Visible = false;
            // 
            // lblProgresslbl
            // 
            this.lblProgresslbl.AutoSize = true;
            this.lblProgresslbl.Location = new System.Drawing.Point(13, 79);
            this.lblProgresslbl.Name = "lblProgresslbl";
            this.lblProgresslbl.Size = new System.Drawing.Size(0, 0);
            this.lblProgresslbl.TabIndex = 26;
            // 
            // lblCurrentToken
            // 
            this.lblCurrentToken.AutoSize = true;
            this.lblCurrentToken.Location = new System.Drawing.Point(13, 53);
            this.lblCurrentToken.Name = "lblCurrentToken";
            this.lblCurrentToken.Size = new System.Drawing.Size(90, 19);
            this.lblCurrentToken.TabIndex = 25;
            this.lblCurrentToken.Text = "Current Token";
            // 
            // txtCurrentToken
            // 
            this.txtCurrentToken.Enabled = false;
            this.txtCurrentToken.Location = new System.Drawing.Point(105, 53);
            this.txtCurrentToken.Name = "txtCurrentToken";
            this.txtCurrentToken.ReadOnly = true;
            this.txtCurrentToken.Size = new System.Drawing.Size(82, 20);
            this.txtCurrentToken.TabIndex = 24;
            // 
            // lblPrevToken
            // 
            this.lblPrevToken.AutoSize = true;
            this.lblPrevToken.Location = new System.Drawing.Point(13, 28);
            this.lblPrevToken.Name = "lblPrevToken";
            this.lblPrevToken.Size = new System.Drawing.Size(68, 19);
            this.lblPrevToken.TabIndex = 23;
            this.lblPrevToken.Text = "Last Token";
            // 
            // proUser
            // 
            this.proUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.proUser.Location = new System.Drawing.Point(19, 123);
            this.proUser.Name = "proUser";
            this.proUser.Size = new System.Drawing.Size(168, 23);
            this.proUser.TabIndex = 50;
            this.proUser.Visible = false;
            // 
            // txtPrevToken
            // 
            this.txtPrevToken.Enabled = false;
            this.txtPrevToken.Location = new System.Drawing.Point(105, 27);
            this.txtPrevToken.Name = "txtPrevToken";
            this.txtPrevToken.ReadOnly = true;
            this.txtPrevToken.Size = new System.Drawing.Size(82, 20);
            this.txtPrevToken.TabIndex = 22;
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Location = new System.Drawing.Point(13, 7);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(81, 19);
            this.lblCurrentUser.TabIndex = 21;
            this.lblCurrentUser.Text = "Current user";
            // 
            // txtCurrentUser
            // 
            this.txtCurrentUser.Enabled = false;
            this.txtCurrentUser.Location = new System.Drawing.Point(105, 4);
            this.txtCurrentUser.Name = "txtCurrentUser";
            this.txtCurrentUser.ReadOnly = true;
            this.txtCurrentUser.Size = new System.Drawing.Size(127, 20);
            this.txtCurrentUser.TabIndex = 20;
            // 
            // lstBackupUsers
            // 
            this.lstBackupUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUsers});
            this.lstBackupUsers.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstBackupUsers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lstBackupUsers.FullRowSelect = true;
            this.lstBackupUsers.Location = new System.Drawing.Point(0, 0);
            this.lstBackupUsers.Name = "lstBackupUsers";
            this.lstBackupUsers.OwnerDraw = true;
            this.lstBackupUsers.Size = new System.Drawing.Size(177, 486);
            this.lstBackupUsers.TabIndex = 55;
            this.lstBackupUsers.UseCompatibleStateImageBehavior = false;
            this.lstBackupUsers.UseSelectable = true;
            this.lstBackupUsers.View = System.Windows.Forms.View.Details;
            // 
            // colUsers
            // 
            this.colUsers.Text = "Users";
            this.colUsers.Width = 173;
            // 
            // tabRestore
            // 
            this.tabRestore.Controls.Add(this.tabControlAdv1);
            this.tabRestore.Controls.Add(this.lblUserTitle);
            this.tabRestore.Controls.Add(this.listBox1);
            this.tabRestore.Location = new System.Drawing.Point(4, 38);
            this.tabRestore.Name = "tabRestore";
            this.tabRestore.Size = new System.Drawing.Size(792, 489);
            this.tabRestore.TabIndex = 1;
            this.tabRestore.Text = "View and Restore";
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Controls.Add(this.tabEmail);
            this.tabControlAdv1.Location = new System.Drawing.Point(271, 0);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.Padding = new System.Drawing.Point(63, 3);
            this.tabControlAdv1.SelectedIndex = 0;
            this.tabControlAdv1.Size = new System.Drawing.Size(521, 474);
            this.tabControlAdv1.TabIndex = 53;
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.Controls.Add(this.lstFiles);
            this.tabPageAdv1.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.Size = new System.Drawing.Size(513, 448);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "Drive";
            // 
            // lstFiles
            // 
            this.lstFiles.BackColor = System.Drawing.Color.White;
            this.lstFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstFiles.ContextMenuStrip = this.conMenuStrip;
            this.lstFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFiles.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lstFiles.FullRowSelect = true;
            this.lstFiles.LabelWrap = false;
            this.lstFiles.Location = new System.Drawing.Point(0, 0);
            this.lstFiles.MultiSelect = false;
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.OwnerDraw = true;
            this.lstFiles.Size = new System.Drawing.Size(513, 448);
            this.lstFiles.TabIndex = 2;
            this.lstFiles.UseCompatibleStateImageBehavior = false;
            this.lstFiles.UseSelectable = true;
            this.lstFiles.View = System.Windows.Forms.View.Details;
            this.lstFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstFiles_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Files";
            this.columnHeader1.Width = 151;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Size";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Full Path";
            this.columnHeader3.Width = 279;
            // 
            // tabEmail
            // 
            this.tabEmail.Controls.Add(this.lblNA);
            this.tabEmail.Controls.Add(this.lstGmail);
            this.tabEmail.Controls.Add(this.lblSent);
            this.tabEmail.Controls.Add(this.lblInbox);
            this.tabEmail.Controls.Add(this.lblUnread);
            this.tabEmail.Location = new System.Drawing.Point(4, 22);
            this.tabEmail.Name = "tabEmail";
            this.tabEmail.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmail.Size = new System.Drawing.Size(513, 451);
            this.tabEmail.TabIndex = 2;
            this.tabEmail.Text = "Email";
            this.tabEmail.UseVisualStyleBackColor = true;
            // 
            // lblNA
            // 
            this.lblNA.AutoSize = true;
            this.lblNA.Location = new System.Drawing.Point(269, 89);
            this.lblNA.Name = "lblNA";
            this.lblNA.Size = new System.Drawing.Size(181, 19);
            this.lblNA.TabIndex = 4;
            this.lblNA.Text = "Sorry, this is not available yet!";
            // 
            // lstGmail
            // 
            this.lstGmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstGmail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEmail});
            this.lstGmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lstGmail.FullRowSelect = true;
            this.lstGmail.Location = new System.Drawing.Point(105, 0);
            this.lstGmail.Name = "lstGmail";
            this.lstGmail.OwnerDraw = true;
            this.lstGmail.Size = new System.Drawing.Size(405, 167);
            this.lstGmail.TabIndex = 3;
            this.lstGmail.UseCompatibleStateImageBehavior = false;
            this.lstGmail.UseSelectable = true;
            this.lstGmail.View = System.Windows.Forms.View.Details;
            // 
            // colEmail
            // 
            this.colEmail.Text = "Email";
            // 
            // lblSent
            // 
            this.lblSent.AutoSize = true;
            this.lblSent.Location = new System.Drawing.Point(22, 89);
            this.lblSent.Name = "lblSent";
            this.lblSent.Size = new System.Drawing.Size(34, 19);
            this.lblSent.TabIndex = 2;
            this.lblSent.Text = "Sent";
            // 
            // lblInbox
            // 
            this.lblInbox.AutoSize = true;
            this.lblInbox.Location = new System.Drawing.Point(22, 53);
            this.lblInbox.Name = "lblInbox";
            this.lblInbox.Size = new System.Drawing.Size(41, 19);
            this.lblInbox.TabIndex = 1;
            this.lblInbox.Text = "Inbox";
            // 
            // lblUnread
            // 
            this.lblUnread.AutoSize = true;
            this.lblUnread.Location = new System.Drawing.Point(22, 20);
            this.lblUnread.Name = "lblUnread";
            this.lblUnread.Size = new System.Drawing.Size(52, 19);
            this.lblUnread.TabIndex = 0;
            this.lblUnread.Text = "Unread";
            // 
            // lblUserTitle
            // 
            this.lblUserTitle.AutoSize = true;
            this.lblUserTitle.Location = new System.Drawing.Point(345, 178);
            this.lblUserTitle.Name = "lblUserTitle";
            this.lblUserTitle.Size = new System.Drawing.Size(40, 19);
            this.lblUserTitle.TabIndex = 41;
            this.lblUserTitle.Text = "Users";
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(268, 489);
            this.listBox1.TabIndex = 39;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblFound
            // 
            this.lblFound.AutoSize = true;
            this.lblFound.Location = new System.Drawing.Point(278, 410);
            this.lblFound.Name = "lblFound";
            this.lblFound.Size = new System.Drawing.Size(0, 13);
            this.lblFound.TabIndex = 53;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblFound);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(812, 640);
            this.panel2.TabIndex = 35;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(812, 24);
            this.menuStrip1.TabIndex = 56;
            this.menuStrip1.Text = "menuStrip2";
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
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.BackColor = System.Drawing.Color.White;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.Location = new System.Drawing.Point(0, 0);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(812, 24);
            this.miniToolStrip.TabIndex = 56;
            // 
            // notifyTray
            // 
            this.notifyTray.ContextMenuStrip = this.conNotifyTray;
            this.notifyTray.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyTray.Icon")));
            this.notifyTray.Text = "TTO GSuite Bkup";
            this.notifyTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyTray_MouseDoubleClick);
            // 
            // conNotifyTray
            // 
            this.conNotifyTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.conNotifyTray.Name = "conNotifyTray";
            this.conNotifyTray.Size = new System.Drawing.Size(114, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem1.Text = "Restore";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem2.Text = "Exit";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // bgwAD
            // 
            this.bgwAD.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwAD_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(814, 667);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(1, 60, 1, 1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TTO: Google Drive Backup --- Mike Tucker http://ttobackup.readme.io/";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.conMenuStrip.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.tabBackup.ResumeLayout(false);
            this.tabBackup.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabRestore.ResumeLayout(false);
            this.tabRestore.PerformLayout();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.tabEmail.ResumeLayout(false);
            this.tabEmail.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.conNotifyTray.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.ComponentModel.BackgroundWorker bgW;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripStatusLabel stripLabel;
        private System.ComponentModel.BackgroundWorker bgLDAP;
        private System.ComponentModel.BackgroundWorker bgSkipFile;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ContextMenuStrip conMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem conRestore;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem conUserMenu;
        private System.Windows.Forms.ToolStripMenuItem conRefreshRight;
        private System.Windows.Forms.ToolStripButton toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblFile;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabel1;
        private MetroFramework.Controls.MetroPanel panel4;
        private System.Windows.Forms.Button btnPref;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button buttonAdv1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabBackup;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSkipUser;
        private MetroFramework.Controls.MetroLabel lblProgresslbl;
        private MetroFramework.Controls.MetroLabel lblCurrentToken;
        private System.Windows.Forms.TextBox txtCurrentToken;
        private MetroFramework.Controls.MetroLabel lblPrevToken;
        private MetroFramework.Controls.MetroProgressBar proUser;
        private System.Windows.Forms.TextBox txtPrevToken;
        private MetroFramework.Controls.MetroLabel lblCurrentUser;
        private System.Windows.Forms.TextBox txtCurrentUser;
        private MetroFramework.Controls.MetroListView lstBackupUsers;
        private System.Windows.Forms.ColumnHeader colUsers;
        private System.Windows.Forms.TabPage tabRestore;
        private System.Windows.Forms.TabControl tabControlAdv1;
        private System.Windows.Forms.TabPage tabPageAdv1;
        protected MetroFramework.Controls.MetroListView lstFiles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TabPage tabEmail;
        private MetroFramework.Controls.MetroLabel lblNA;
        private MetroFramework.Controls.MetroListView lstGmail;
        private System.Windows.Forms.ColumnHeader colEmail;
        private MetroFramework.Controls.MetroLabel lblSent;
        private MetroFramework.Controls.MetroLabel lblInbox;
        private MetroFramework.Controls.MetroLabel lblUnread;
        private MetroFramework.Controls.MetroLabel lblUserTitle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblFound;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip miniToolStrip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.NotifyIcon notifyTray;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip conNotifyTray;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.ComponentModel.BackgroundWorker bgwAD;
    }
}

