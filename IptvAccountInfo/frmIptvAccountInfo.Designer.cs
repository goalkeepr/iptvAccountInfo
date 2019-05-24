namespace IptvAccountInfo
{
    partial class frmIptvAccountInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIptvAccountInfo));
            this.lblM3uUrl = new System.Windows.Forms.Label();
            this.txtM3uUrl = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.lblExpiresDate = new System.Windows.Forms.Label();
            this.lblAccountStatus = new System.Windows.Forms.Label();
            this.lblOutputFormats = new System.Windows.Forms.Label();
            this.lblActiveConnections = new System.Windows.Forms.Label();
            this.lblMaxConnections = new System.Windows.Forms.Label();
            this.lblLiveCategories = new System.Windows.Forms.Label();
            this.lblMovieCategories = new System.Windows.Forms.Label();
            this.lblSeriesCategories = new System.Windows.Forms.Label();
            this.lblTotalChannels = new System.Windows.Forms.Label();
            this.cboInfoType = new System.Windows.Forms.ComboBox();
            this.grpAccountCredentials = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPortalUrl = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPortalUrl = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.grpUrls = new System.Windows.Forms.GroupBox();
            this.lblWatchOnline = new System.Windows.Forms.LinkLabel();
            this.lblXmlEpg = new System.Windows.Forms.LinkLabel();
            this.lblHlsM3u = new System.Windows.Forms.LinkLabel();
            this.lblTsM3u = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCreateShortLinks = new System.Windows.Forms.Button();
            this.lblXmlEpgShort = new System.Windows.Forms.LinkLabel();
            this.lblHlsM3uShort = new System.Windows.Forms.LinkLabel();
            this.lblTsM3uShort = new System.Windows.Forms.LinkLabel();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCatchupChannels = new System.Windows.Forms.Label();
            this.grpAccountCredentials.SuspendLayout();
            this.grpUrls.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblM3uUrl
            // 
            this.lblM3uUrl.AutoSize = true;
            this.lblM3uUrl.Location = new System.Drawing.Point(172, 30);
            this.lblM3uUrl.Name = "lblM3uUrl";
            this.lblM3uUrl.Size = new System.Drawing.Size(94, 14);
            this.lblM3uUrl.TabIndex = 0;
            this.lblM3uUrl.Text = "M3U or EPG URL:";
            // 
            // txtM3uUrl
            // 
            this.txtM3uUrl.Location = new System.Drawing.Point(284, 39);
            this.txtM3uUrl.Name = "txtM3uUrl";
            this.txtM3uUrl.Size = new System.Drawing.Size(287, 22);
            this.txtM3uUrl.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(577, 38);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Go";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Created Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Expires Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Account Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Output Formats";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 14);
            this.label5.TabIndex = 7;
            this.label5.Text = "Active Connections";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 14);
            this.label6.TabIndex = 8;
            this.label6.Text = "Max Connections";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(470, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 14);
            this.label9.TabIndex = 11;
            this.label9.Text = "Live Categories";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(470, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 14);
            this.label10.TabIndex = 12;
            this.label10.Text = "Movie Categories";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(470, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 14);
            this.label11.TabIndex = 13;
            this.label11.Text = "Series Categories";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(470, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 14);
            this.label12.TabIndex = 14;
            this.label12.Text = "Total Channels";
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Location = new System.Drawing.Point(143, 18);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(39, 14);
            this.lblCreatedDate.TabIndex = 15;
            this.lblCreatedDate.Text = "--------";
            this.lblCreatedDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblExpiresDate
            // 
            this.lblExpiresDate.AutoSize = true;
            this.lblExpiresDate.Location = new System.Drawing.Point(143, 32);
            this.lblExpiresDate.Name = "lblExpiresDate";
            this.lblExpiresDate.Size = new System.Drawing.Size(39, 14);
            this.lblExpiresDate.TabIndex = 16;
            this.lblExpiresDate.Text = "--------";
            this.lblExpiresDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAccountStatus
            // 
            this.lblAccountStatus.AutoSize = true;
            this.lblAccountStatus.Location = new System.Drawing.Point(143, 46);
            this.lblAccountStatus.Name = "lblAccountStatus";
            this.lblAccountStatus.Size = new System.Drawing.Size(39, 14);
            this.lblAccountStatus.TabIndex = 17;
            this.lblAccountStatus.Text = "--------";
            this.lblAccountStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblOutputFormats
            // 
            this.lblOutputFormats.AutoSize = true;
            this.lblOutputFormats.Location = new System.Drawing.Point(143, 60);
            this.lblOutputFormats.Name = "lblOutputFormats";
            this.lblOutputFormats.Size = new System.Drawing.Size(39, 14);
            this.lblOutputFormats.TabIndex = 18;
            this.lblOutputFormats.Text = "--------";
            this.lblOutputFormats.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblActiveConnections
            // 
            this.lblActiveConnections.AutoSize = true;
            this.lblActiveConnections.Location = new System.Drawing.Point(379, 18);
            this.lblActiveConnections.Name = "lblActiveConnections";
            this.lblActiveConnections.Size = new System.Drawing.Size(39, 14);
            this.lblActiveConnections.TabIndex = 19;
            this.lblActiveConnections.Text = "--------";
            this.lblActiveConnections.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMaxConnections
            // 
            this.lblMaxConnections.AutoSize = true;
            this.lblMaxConnections.Location = new System.Drawing.Point(379, 32);
            this.lblMaxConnections.Name = "lblMaxConnections";
            this.lblMaxConnections.Size = new System.Drawing.Size(39, 14);
            this.lblMaxConnections.TabIndex = 20;
            this.lblMaxConnections.Text = "--------";
            this.lblMaxConnections.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLiveCategories
            // 
            this.lblLiveCategories.Location = new System.Drawing.Point(600, 18);
            this.lblLiveCategories.Name = "lblLiveCategories";
            this.lblLiveCategories.Size = new System.Drawing.Size(39, 14);
            this.lblLiveCategories.TabIndex = 21;
            this.lblLiveCategories.Text = "--------";
            this.lblLiveCategories.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMovieCategories
            // 
            this.lblMovieCategories.Location = new System.Drawing.Point(600, 32);
            this.lblMovieCategories.Name = "lblMovieCategories";
            this.lblMovieCategories.Size = new System.Drawing.Size(39, 14);
            this.lblMovieCategories.TabIndex = 22;
            this.lblMovieCategories.Text = "--------";
            this.lblMovieCategories.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSeriesCategories
            // 
            this.lblSeriesCategories.Location = new System.Drawing.Point(600, 46);
            this.lblSeriesCategories.Name = "lblSeriesCategories";
            this.lblSeriesCategories.Size = new System.Drawing.Size(39, 14);
            this.lblSeriesCategories.TabIndex = 23;
            this.lblSeriesCategories.Text = "--------";
            this.lblSeriesCategories.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotalChannels
            // 
            this.lblTotalChannels.Location = new System.Drawing.Point(600, 60);
            this.lblTotalChannels.Name = "lblTotalChannels";
            this.lblTotalChannels.Size = new System.Drawing.Size(39, 14);
            this.lblTotalChannels.TabIndex = 24;
            this.lblTotalChannels.Text = "--------";
            this.lblTotalChannels.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboInfoType
            // 
            this.cboInfoType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInfoType.FormattingEnabled = true;
            this.cboInfoType.Items.AddRange(new object[] {
            "M3U/EPG URL",
            "Server/User ID/Password"});
            this.cboInfoType.Location = new System.Drawing.Point(30, 39);
            this.cboInfoType.Name = "cboInfoType";
            this.cboInfoType.Size = new System.Drawing.Size(148, 22);
            this.cboInfoType.TabIndex = 25;
            this.cboInfoType.SelectedIndexChanged += new System.EventHandler(this.CboInfoType_SelectedIndexChanged);
            // 
            // grpAccountCredentials
            // 
            this.grpAccountCredentials.Controls.Add(this.txtPassword);
            this.grpAccountCredentials.Controls.Add(this.lblPortalUrl);
            this.grpAccountCredentials.Controls.Add(this.lblPassword);
            this.grpAccountCredentials.Controls.Add(this.txtPortalUrl);
            this.grpAccountCredentials.Controls.Add(this.txtUserId);
            this.grpAccountCredentials.Controls.Add(this.lblUserId);
            this.grpAccountCredentials.Controls.Add(this.lblM3uUrl);
            this.grpAccountCredentials.Location = new System.Drawing.Point(12, 12);
            this.grpAccountCredentials.Name = "grpAccountCredentials";
            this.grpAccountCredentials.Size = new System.Drawing.Size(820, 113);
            this.grpAccountCredentials.TabIndex = 26;
            this.grpAccountCredentials.TabStop = false;
            this.grpAccountCredentials.Text = "Enter Account Credentials";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(272, 79);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(145, 22);
            this.txtPassword.TabIndex = 32;
            this.txtPassword.Visible = false;
            // 
            // lblPortalUrl
            // 
            this.lblPortalUrl.AutoSize = true;
            this.lblPortalUrl.Location = new System.Drawing.Point(172, 30);
            this.lblPortalUrl.Name = "lblPortalUrl";
            this.lblPortalUrl.Size = new System.Drawing.Size(65, 14);
            this.lblPortalUrl.TabIndex = 27;
            this.lblPortalUrl.Text = "Portal URL:";
            this.lblPortalUrl.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(172, 82);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(62, 14);
            this.lblPassword.TabIndex = 31;
            this.lblPassword.Text = "Password:";
            this.lblPassword.Visible = false;
            // 
            // txtPortalUrl
            // 
            this.txtPortalUrl.Location = new System.Drawing.Point(272, 27);
            this.txtPortalUrl.Name = "txtPortalUrl";
            this.txtPortalUrl.Size = new System.Drawing.Size(145, 22);
            this.txtPortalUrl.TabIndex = 28;
            this.txtPortalUrl.Visible = false;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(272, 53);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(145, 22);
            this.txtUserId.TabIndex = 30;
            this.txtUserId.Visible = false;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(172, 56);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(50, 14);
            this.lblUserId.TabIndex = 29;
            this.lblUserId.Text = "User ID:";
            this.lblUserId.Visible = false;
            // 
            // grpUrls
            // 
            this.grpUrls.Controls.Add(this.lblWatchOnline);
            this.grpUrls.Controls.Add(this.lblXmlEpg);
            this.grpUrls.Controls.Add(this.lblHlsM3u);
            this.grpUrls.Controls.Add(this.lblTsM3u);
            this.grpUrls.Controls.Add(this.label8);
            this.grpUrls.Controls.Add(this.label16);
            this.grpUrls.Controls.Add(this.label15);
            this.grpUrls.Controls.Add(this.label14);
            this.grpUrls.Location = new System.Drawing.Point(12, 131);
            this.grpUrls.Name = "grpUrls";
            this.grpUrls.Size = new System.Drawing.Size(820, 94);
            this.grpUrls.TabIndex = 27;
            this.grpUrls.TabStop = false;
            this.grpUrls.Text = "Account URLs";
            // 
            // lblWatchOnline
            // 
            this.lblWatchOnline.AutoSize = true;
            this.lblWatchOnline.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblWatchOnline.Location = new System.Drawing.Point(143, 60);
            this.lblWatchOnline.Name = "lblWatchOnline";
            this.lblWatchOnline.Size = new System.Drawing.Size(39, 14);
            this.lblWatchOnline.TabIndex = 39;
            this.lblWatchOnline.TabStop = true;
            this.lblWatchOnline.Text = "--------";
            this.lblWatchOnline.Click += new System.EventHandler(this.CopyToClipboard);
            // 
            // lblXmlEpg
            // 
            this.lblXmlEpg.AutoSize = true;
            this.lblXmlEpg.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblXmlEpg.Location = new System.Drawing.Point(143, 46);
            this.lblXmlEpg.Name = "lblXmlEpg";
            this.lblXmlEpg.Size = new System.Drawing.Size(39, 14);
            this.lblXmlEpg.TabIndex = 38;
            this.lblXmlEpg.TabStop = true;
            this.lblXmlEpg.Text = "--------";
            this.lblXmlEpg.Click += new System.EventHandler(this.CopyToClipboard);
            // 
            // lblHlsM3u
            // 
            this.lblHlsM3u.AutoSize = true;
            this.lblHlsM3u.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblHlsM3u.Location = new System.Drawing.Point(143, 32);
            this.lblHlsM3u.Name = "lblHlsM3u";
            this.lblHlsM3u.Size = new System.Drawing.Size(39, 14);
            this.lblHlsM3u.TabIndex = 37;
            this.lblHlsM3u.TabStop = true;
            this.lblHlsM3u.Text = "--------";
            this.lblHlsM3u.Click += new System.EventHandler(this.CopyToClipboard);
            // 
            // lblTsM3u
            // 
            this.lblTsM3u.AutoSize = true;
            this.lblTsM3u.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblTsM3u.Location = new System.Drawing.Point(143, 18);
            this.lblTsM3u.Name = "lblTsM3u";
            this.lblTsM3u.Size = new System.Drawing.Size(39, 14);
            this.lblTsM3u.TabIndex = 36;
            this.lblTsM3u.TabStop = true;
            this.lblTsM3u.Text = "--------";
            this.lblTsM3u.Click += new System.EventHandler(this.CopyToClipboard);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 14);
            this.label8.TabIndex = 34;
            this.label8.Text = "Watch Online:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 14);
            this.label16.TabIndex = 28;
            this.label16.Text = "TS M3U:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 14);
            this.label15.TabIndex = 29;
            this.label15.Text = "HLS M3U:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 14);
            this.label14.TabIndex = 30;
            this.label14.Text = "XML EPG:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblCatchupChannels);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblTotalChannels);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblSeriesCategories);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblMovieCategories);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblLiveCategories);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblMaxConnections);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblActiveConnections);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblOutputFormats);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblAccountStatus);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblExpiresDate);
            this.groupBox2.Controls.Add(this.lblCreatedDate);
            this.groupBox2.Location = new System.Drawing.Point(12, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(820, 84);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account Information";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCreateShortLinks);
            this.groupBox3.Controls.Add(this.lblXmlEpgShort);
            this.groupBox3.Controls.Add(this.lblHlsM3uShort);
            this.groupBox3.Controls.Add(this.lblTsM3uShort);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Location = new System.Drawing.Point(12, 333);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(820, 75);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Create Short URLs (Optional!)";
            // 
            // btnCreateShortLinks
            // 
            this.btnCreateShortLinks.Location = new System.Drawing.Point(48, 28);
            this.btnCreateShortLinks.Name = "btnCreateShortLinks";
            this.btnCreateShortLinks.Size = new System.Drawing.Size(75, 23);
            this.btnCreateShortLinks.TabIndex = 40;
            this.btnCreateShortLinks.Text = "Create";
            this.btnCreateShortLinks.UseVisualStyleBackColor = true;
            this.btnCreateShortLinks.Click += new System.EventHandler(this.BtnCreateShortLinks_Click);
            // 
            // lblXmlEpgShort
            // 
            this.lblXmlEpgShort.AutoSize = true;
            this.lblXmlEpgShort.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblXmlEpgShort.Location = new System.Drawing.Point(363, 46);
            this.lblXmlEpgShort.Name = "lblXmlEpgShort";
            this.lblXmlEpgShort.Size = new System.Drawing.Size(39, 14);
            this.lblXmlEpgShort.TabIndex = 38;
            this.lblXmlEpgShort.TabStop = true;
            this.lblXmlEpgShort.Text = "--------";
            this.lblXmlEpgShort.Click += new System.EventHandler(this.CopyToClipboard);
            // 
            // lblHlsM3uShort
            // 
            this.lblHlsM3uShort.AutoSize = true;
            this.lblHlsM3uShort.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblHlsM3uShort.Location = new System.Drawing.Point(363, 32);
            this.lblHlsM3uShort.Name = "lblHlsM3uShort";
            this.lblHlsM3uShort.Size = new System.Drawing.Size(39, 14);
            this.lblHlsM3uShort.TabIndex = 37;
            this.lblHlsM3uShort.TabStop = true;
            this.lblHlsM3uShort.Text = "--------";
            this.lblHlsM3uShort.Click += new System.EventHandler(this.CopyToClipboard);
            // 
            // lblTsM3uShort
            // 
            this.lblTsM3uShort.AutoSize = true;
            this.lblTsM3uShort.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblTsM3uShort.Location = new System.Drawing.Point(363, 18);
            this.lblTsM3uShort.Name = "lblTsM3uShort";
            this.lblTsM3uShort.Size = new System.Drawing.Size(39, 14);
            this.lblTsM3uShort.TabIndex = 36;
            this.lblTsM3uShort.TabStop = true;
            this.lblTsM3uShort.Text = "--------";
            this.lblTsM3uShort.Click += new System.EventHandler(this.CopyToClipboard);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(235, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 14);
            this.label13.TabIndex = 28;
            this.label13.Text = "TS M3U:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(235, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 14);
            this.label17.TabIndex = 29;
            this.label17.Text = "HLS M3U:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(235, 46);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 14);
            this.label18.TabIndex = 30;
            this.label18.Text = "XML EPG:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 14);
            this.label7.TabIndex = 25;
            this.label7.Text = "Catch-Up Channels:";
            // 
            // lblCatchupChannels
            // 
            this.lblCatchupChannels.AutoSize = true;
            this.lblCatchupChannels.Location = new System.Drawing.Point(379, 60);
            this.lblCatchupChannels.Name = "lblCatchupChannels";
            this.lblCatchupChannels.Size = new System.Drawing.Size(39, 14);
            this.lblCatchupChannels.TabIndex = 26;
            this.lblCatchupChannels.Text = "--------";
            this.lblCatchupChannels.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmIptvAccountInfo
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 439);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpUrls);
            this.Controls.Add(this.cboInfoType);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtM3uUrl);
            this.Controls.Add(this.grpAccountCredentials);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIptvAccountInfo";
            this.Text = "IPTV Account Info";
            this.Load += new System.EventHandler(this.FrmIptvAccountInfo_Load);
            this.grpAccountCredentials.ResumeLayout(false);
            this.grpAccountCredentials.PerformLayout();
            this.grpUrls.ResumeLayout(false);
            this.grpUrls.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblM3uUrl;
        private System.Windows.Forms.TextBox txtM3uUrl;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.Label lblExpiresDate;
        private System.Windows.Forms.Label lblAccountStatus;
        private System.Windows.Forms.Label lblOutputFormats;
        private System.Windows.Forms.Label lblActiveConnections;
        private System.Windows.Forms.Label lblMaxConnections;
        private System.Windows.Forms.Label lblLiveCategories;
        private System.Windows.Forms.Label lblMovieCategories;
        private System.Windows.Forms.Label lblSeriesCategories;
        private System.Windows.Forms.Label lblTotalChannels;
        private System.Windows.Forms.ComboBox cboInfoType;
        private System.Windows.Forms.GroupBox grpAccountCredentials;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPortalUrl;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPortalUrl;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.GroupBox grpUrls;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel lblTsM3u;
        private System.Windows.Forms.LinkLabel lblWatchOnline;
        private System.Windows.Forms.LinkLabel lblXmlEpg;
        private System.Windows.Forms.LinkLabel lblHlsM3u;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCreateShortLinks;
        private System.Windows.Forms.LinkLabel lblXmlEpgShort;
        private System.Windows.Forms.LinkLabel lblHlsM3uShort;
        private System.Windows.Forms.LinkLabel lblTsM3uShort;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCatchupChannels;
    }
}

