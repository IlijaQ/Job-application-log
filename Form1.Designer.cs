
namespace JobApplicationLog
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
            this.listbox_companies = new System.Windows.Forms.ListBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_companySite = new System.Windows.Forms.Button();
            this.static_lbl_companyName = new System.Windows.Forms.Label();
            this.lbl_companyName = new System.Windows.Forms.Label();
            this.btn_companyInfo = new System.Windows.Forms.Button();
            this.static_lbl_applicationDate = new System.Windows.Forms.Label();
            this.lbl_applicationDate = new System.Windows.Forms.Label();
            this.static_lbl_pros = new System.Windows.Forms.Label();
            this.static_lbl_cons = new System.Windows.Forms.Label();
            this.lbl_pros = new System.Windows.Forms.Label();
            this.lbl_cons = new System.Windows.Forms.Label();
            this.static_lbl_sourceSite = new System.Windows.Forms.Label();
            this.lbl_sourceSite = new System.Windows.Forms.Label();
            this.btn_companyProfileApp = new System.Windows.Forms.Button();
            this.static_lbl_applicationStatus = new System.Windows.Forms.Label();
            this.lbl_applicationStatus = new System.Windows.Forms.Label();
            this.txtBox_companyName = new System.Windows.Forms.TextBox();
            this.txtBox_sourceSite = new System.Windows.Forms.TextBox();
            this.txtBox_applicationStatus = new System.Windows.Forms.TextBox();
            this.txtBox_companySite = new System.Windows.Forms.TextBox();
            this.txtBox_companyProfileApp = new System.Windows.Forms.TextBox();
            this.txtBox_companyInfo = new System.Windows.Forms.TextBox();
            this.txtBox_pros = new System.Windows.Forms.TextBox();
            this.txtBox_cons = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.dynamic_lbl_companySite = new System.Windows.Forms.Label();
            this.dynamic_lbl_companyInfo = new System.Windows.Forms.Label();
            this.dynamic_lbl_companyProfileApp = new System.Windows.Forms.Label();
            this.btn_deactivateCurrentStatus = new System.Windows.Forms.Button();
            this.numUpDwn_day = new System.Windows.Forms.NumericUpDown();
            this.numUpDwn_month = new System.Windows.Forms.NumericUpDown();
            this.numUpDwn_year = new System.Windows.Forms.NumericUpDown();
            this.btn_jobOffer = new System.Windows.Forms.Button();
            this.lbl_dayInMonth = new System.Windows.Forms.Label();
            this.txtBox_jobDesc = new System.Windows.Forms.TextBox();
            this.groupBox_companySite = new System.Windows.Forms.GroupBox();
            this.groupBox_companyProfileApp = new System.Windows.Forms.GroupBox();
            this.groupBox_companyInfo = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveInAAditionaltxtFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_back = new System.Windows.Forms.Button();
            this.picBox_sourceSite = new System.Windows.Forms.PictureBox();
            this.btn_restoreStatus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_day)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_month)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_year)).BeginInit();
            this.groupBox_companySite.SuspendLayout();
            this.groupBox_companyProfileApp.SuspendLayout();
            this.groupBox_companyInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_sourceSite)).BeginInit();
            this.SuspendLayout();
            // 
            // listbox_companies
            // 
            this.listbox_companies.Dock = System.Windows.Forms.DockStyle.Left;
            this.listbox_companies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_companies.FormattingEnabled = true;
            this.listbox_companies.IntegralHeight = false;
            this.listbox_companies.ItemHeight = 20;
            this.listbox_companies.Location = new System.Drawing.Point(0, 0);
            this.listbox_companies.Name = "listbox_companies";
            this.listbox_companies.Size = new System.Drawing.Size(399, 869);
            this.listbox_companies.TabIndex = 0;
            this.listbox_companies.DoubleClick += new System.EventHandler(this.listbox_companies_DoubleClick);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(1285, 10);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(152, 28);
            this.btn_edit.TabIndex = 3;
            this.btn_edit.Text = "edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_companySite
            // 
            this.btn_companySite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_companySite.Location = new System.Drawing.Point(405, 231);
            this.btn_companySite.Name = "btn_companySite";
            this.btn_companySite.Size = new System.Drawing.Size(314, 29);
            this.btn_companySite.TabIndex = 4;
            this.btn_companySite.Text = "company site";
            this.btn_companySite.UseVisualStyleBackColor = true;
            this.btn_companySite.Click += new System.EventHandler(this.btn_companySite_Click);
            // 
            // static_lbl_companyName
            // 
            this.static_lbl_companyName.AutoSize = true;
            this.static_lbl_companyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.static_lbl_companyName.Location = new System.Drawing.Point(405, 53);
            this.static_lbl_companyName.Name = "static_lbl_companyName";
            this.static_lbl_companyName.Size = new System.Drawing.Size(127, 20);
            this.static_lbl_companyName.TabIndex = 5;
            this.static_lbl_companyName.Text = "company name:";
            // 
            // lbl_companyName
            // 
            this.lbl_companyName.AutoSize = true;
            this.lbl_companyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_companyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_companyName.Location = new System.Drawing.Point(547, 46);
            this.lbl_companyName.Name = "lbl_companyName";
            this.lbl_companyName.Size = new System.Drawing.Size(188, 29);
            this.lbl_companyName.TabIndex = 6;
            this.lbl_companyName.Text = "company name";
            // 
            // btn_companyInfo
            // 
            this.btn_companyInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_companyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_companyInfo.Location = new System.Drawing.Point(1125, 231);
            this.btn_companyInfo.Name = "btn_companyInfo";
            this.btn_companyInfo.Size = new System.Drawing.Size(312, 29);
            this.btn_companyInfo.TabIndex = 7;
            this.btn_companyInfo.Text = "company info";
            this.btn_companyInfo.UseVisualStyleBackColor = true;
            this.btn_companyInfo.Click += new System.EventHandler(this.btn_companyInfo_Click);
            // 
            // static_lbl_applicationDate
            // 
            this.static_lbl_applicationDate.AutoSize = true;
            this.static_lbl_applicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.static_lbl_applicationDate.Location = new System.Drawing.Point(405, 96);
            this.static_lbl_applicationDate.Name = "static_lbl_applicationDate";
            this.static_lbl_applicationDate.Size = new System.Drawing.Size(131, 20);
            this.static_lbl_applicationDate.TabIndex = 8;
            this.static_lbl_applicationDate.Text = "application date:";
            // 
            // lbl_applicationDate
            // 
            this.lbl_applicationDate.AutoSize = true;
            this.lbl_applicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_applicationDate.Location = new System.Drawing.Point(549, 97);
            this.lbl_applicationDate.Name = "lbl_applicationDate";
            this.lbl_applicationDate.Size = new System.Drawing.Size(126, 18);
            this.lbl_applicationDate.TabIndex = 9;
            this.lbl_applicationDate.Text = "application date";
            // 
            // static_lbl_pros
            // 
            this.static_lbl_pros.AutoSize = true;
            this.static_lbl_pros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.static_lbl_pros.Location = new System.Drawing.Point(405, 278);
            this.static_lbl_pros.Name = "static_lbl_pros";
            this.static_lbl_pros.Size = new System.Drawing.Size(47, 20);
            this.static_lbl_pros.TabIndex = 12;
            this.static_lbl_pros.Text = "pros:";
            // 
            // static_lbl_cons
            // 
            this.static_lbl_cons.AutoSize = true;
            this.static_lbl_cons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.static_lbl_cons.Location = new System.Drawing.Point(405, 325);
            this.static_lbl_cons.Name = "static_lbl_cons";
            this.static_lbl_cons.Size = new System.Drawing.Size(50, 20);
            this.static_lbl_cons.TabIndex = 13;
            this.static_lbl_cons.Text = "cons:";
            // 
            // lbl_pros
            // 
            this.lbl_pros.AutoSize = true;
            this.lbl_pros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pros.Location = new System.Drawing.Point(548, 278);
            this.lbl_pros.Name = "lbl_pros";
            this.lbl_pros.Size = new System.Drawing.Size(42, 20);
            this.lbl_pros.TabIndex = 14;
            this.lbl_pros.Text = "pros";
            // 
            // lbl_cons
            // 
            this.lbl_cons.AutoSize = true;
            this.lbl_cons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cons.Location = new System.Drawing.Point(548, 325);
            this.lbl_cons.Name = "lbl_cons";
            this.lbl_cons.Size = new System.Drawing.Size(45, 20);
            this.lbl_cons.TabIndex = 15;
            this.lbl_cons.Text = "cons";
            // 
            // static_lbl_sourceSite
            // 
            this.static_lbl_sourceSite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.static_lbl_sourceSite.AutoSize = true;
            this.static_lbl_sourceSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.static_lbl_sourceSite.Location = new System.Drawing.Point(1174, 97);
            this.static_lbl_sourceSite.Name = "static_lbl_sourceSite";
            this.static_lbl_sourceSite.Size = new System.Drawing.Size(97, 20);
            this.static_lbl_sourceSite.TabIndex = 17;
            this.static_lbl_sourceSite.Text = "source site:";
            // 
            // lbl_sourceSite
            // 
            this.lbl_sourceSite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_sourceSite.AutoSize = true;
            this.lbl_sourceSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sourceSite.Location = new System.Drawing.Point(1285, 97);
            this.lbl_sourceSite.Name = "lbl_sourceSite";
            this.lbl_sourceSite.Size = new System.Drawing.Size(103, 20);
            this.lbl_sourceSite.TabIndex = 18;
            this.lbl_sourceSite.Text = "source site";
            // 
            // btn_companyProfileApp
            // 
            this.btn_companyProfileApp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_companyProfileApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_companyProfileApp.Location = new System.Drawing.Point(815, 231);
            this.btn_companyProfileApp.Name = "btn_companyProfileApp";
            this.btn_companyProfileApp.Size = new System.Drawing.Size(214, 29);
            this.btn_companyProfileApp.TabIndex = 19;
            this.btn_companyProfileApp.Text = "profile";
            this.btn_companyProfileApp.UseVisualStyleBackColor = true;
            this.btn_companyProfileApp.Click += new System.EventHandler(this.btn_companyProfileApp_Click);
            // 
            // static_lbl_applicationStatus
            // 
            this.static_lbl_applicationStatus.AutoSize = true;
            this.static_lbl_applicationStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.static_lbl_applicationStatus.Location = new System.Drawing.Point(405, 140);
            this.static_lbl_applicationStatus.Name = "static_lbl_applicationStatus";
            this.static_lbl_applicationStatus.Size = new System.Drawing.Size(60, 20);
            this.static_lbl_applicationStatus.TabIndex = 20;
            this.static_lbl_applicationStatus.Text = "status:";
            // 
            // lbl_applicationStatus
            // 
            this.lbl_applicationStatus.AutoSize = true;
            this.lbl_applicationStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_applicationStatus.Location = new System.Drawing.Point(548, 138);
            this.lbl_applicationStatus.Name = "lbl_applicationStatus";
            this.lbl_applicationStatus.Size = new System.Drawing.Size(140, 20);
            this.lbl_applicationStatus.TabIndex = 21;
            this.lbl_applicationStatus.Text = "application status";
            // 
            // txtBox_companyName
            // 
            this.txtBox_companyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_companyName.Location = new System.Drawing.Point(552, 48);
            this.txtBox_companyName.Name = "txtBox_companyName";
            this.txtBox_companyName.Size = new System.Drawing.Size(259, 27);
            this.txtBox_companyName.TabIndex = 22;
            // 
            // txtBox_sourceSite
            // 
            this.txtBox_sourceSite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_sourceSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_sourceSite.Location = new System.Drawing.Point(1285, 89);
            this.txtBox_sourceSite.Name = "txtBox_sourceSite";
            this.txtBox_sourceSite.Size = new System.Drawing.Size(152, 27);
            this.txtBox_sourceSite.TabIndex = 24;
            // 
            // txtBox_applicationStatus
            // 
            this.txtBox_applicationStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_applicationStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_applicationStatus.Location = new System.Drawing.Point(552, 131);
            this.txtBox_applicationStatus.Name = "txtBox_applicationStatus";
            this.txtBox_applicationStatus.Size = new System.Drawing.Size(620, 27);
            this.txtBox_applicationStatus.TabIndex = 25;
            // 
            // txtBox_companySite
            // 
            this.txtBox_companySite.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_companySite.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtBox_companySite.Location = new System.Drawing.Point(0, 61);
            this.txtBox_companySite.Name = "txtBox_companySite";
            this.txtBox_companySite.Size = new System.Drawing.Size(312, 22);
            this.txtBox_companySite.TabIndex = 26;
            // 
            // txtBox_companyProfileApp
            // 
            this.txtBox_companyProfileApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_companyProfileApp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtBox_companyProfileApp.Location = new System.Drawing.Point(75, 61);
            this.txtBox_companyProfileApp.Name = "txtBox_companyProfileApp";
            this.txtBox_companyProfileApp.Size = new System.Drawing.Size(214, 22);
            this.txtBox_companyProfileApp.TabIndex = 27;
            // 
            // txtBox_companyInfo
            // 
            this.txtBox_companyInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_companyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_companyInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtBox_companyInfo.Location = new System.Drawing.Point(6, 61);
            this.txtBox_companyInfo.Name = "txtBox_companyInfo";
            this.txtBox_companyInfo.Size = new System.Drawing.Size(310, 22);
            this.txtBox_companyInfo.TabIndex = 28;
            // 
            // txtBox_pros
            // 
            this.txtBox_pros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_pros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_pros.Location = new System.Drawing.Point(552, 271);
            this.txtBox_pros.Name = "txtBox_pros";
            this.txtBox_pros.Size = new System.Drawing.Size(885, 27);
            this.txtBox_pros.TabIndex = 29;
            // 
            // txtBox_cons
            // 
            this.txtBox_cons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_cons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_cons.Location = new System.Drawing.Point(552, 318);
            this.txtBox_cons.Name = "txtBox_cons";
            this.txtBox_cons.Size = new System.Drawing.Size(885, 27);
            this.txtBox_cons.TabIndex = 30;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(1285, 10);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(152, 28);
            this.btn_save.TabIndex = 32;
            this.btn_save.Text = "save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dynamic_lbl_companySite
            // 
            this.dynamic_lbl_companySite.BackColor = System.Drawing.Color.Transparent;
            this.dynamic_lbl_companySite.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dynamic_lbl_companySite.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dynamic_lbl_companySite.Location = new System.Drawing.Point(6, 14);
            this.dynamic_lbl_companySite.Name = "dynamic_lbl_companySite";
            this.dynamic_lbl_companySite.Size = new System.Drawing.Size(308, 47);
            this.dynamic_lbl_companySite.TabIndex = 33;
            this.dynamic_lbl_companySite.Text = "paste the company site URL here to enable this button to launch browser and visit" +
    " this link\r\n";
            this.dynamic_lbl_companySite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dynamic_lbl_companyInfo
            // 
            this.dynamic_lbl_companyInfo.BackColor = System.Drawing.Color.Transparent;
            this.dynamic_lbl_companyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dynamic_lbl_companyInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dynamic_lbl_companyInfo.Location = new System.Drawing.Point(6, 12);
            this.dynamic_lbl_companyInfo.Name = "dynamic_lbl_companyInfo";
            this.dynamic_lbl_companyInfo.Size = new System.Drawing.Size(356, 52);
            this.dynamic_lbl_companyInfo.TabIndex = 34;
            this.dynamic_lbl_companyInfo.Text = "if the company provides its own web service to submit and track your job applicat" +
    "ion, put it\'s URL here; otherwise the button will not appear";
            this.dynamic_lbl_companyInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dynamic_lbl_companyProfileApp
            // 
            this.dynamic_lbl_companyProfileApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dynamic_lbl_companyProfileApp.BackColor = System.Drawing.SystemColors.Control;
            this.dynamic_lbl_companyProfileApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dynamic_lbl_companyProfileApp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dynamic_lbl_companyProfileApp.Location = new System.Drawing.Point(16, 17);
            this.dynamic_lbl_companyProfileApp.Name = "dynamic_lbl_companyProfileApp";
            this.dynamic_lbl_companyProfileApp.Size = new System.Drawing.Size(296, 40);
            this.dynamic_lbl_companyProfileApp.TabIndex = 35;
            this.dynamic_lbl_companyProfileApp.Text = "paste here the URL of a third party website that provides reviews about the compa" +
    "ny";
            this.dynamic_lbl_companyProfileApp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_deactivateCurrentStatus
            // 
            this.btn_deactivateCurrentStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deactivateCurrentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deactivateCurrentStatus.Location = new System.Drawing.Point(1178, 131);
            this.btn_deactivateCurrentStatus.Name = "btn_deactivateCurrentStatus";
            this.btn_deactivateCurrentStatus.Size = new System.Drawing.Size(101, 27);
            this.btn_deactivateCurrentStatus.TabIndex = 37;
            this.btn_deactivateCurrentStatus.Text = "deactivate";
            this.btn_deactivateCurrentStatus.UseVisualStyleBackColor = true;
            this.btn_deactivateCurrentStatus.Click += new System.EventHandler(this.btn_deactivateCurrentStatus_Click);
            // 
            // numUpDwn_day
            // 
            this.numUpDwn_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDwn_day.Location = new System.Drawing.Point(552, 88);
            this.numUpDwn_day.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numUpDwn_day.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDwn_day.Name = "numUpDwn_day";
            this.numUpDwn_day.Size = new System.Drawing.Size(95, 27);
            this.numUpDwn_day.TabIndex = 38;
            this.numUpDwn_day.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUpDwn_day.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numUpDwn_month
            // 
            this.numUpDwn_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDwn_month.Location = new System.Drawing.Point(653, 88);
            this.numUpDwn_month.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numUpDwn_month.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDwn_month.Name = "numUpDwn_month";
            this.numUpDwn_month.Size = new System.Drawing.Size(57, 27);
            this.numUpDwn_month.TabIndex = 39;
            this.numUpDwn_month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDwn_month.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDwn_month.ValueChanged += new System.EventHandler(this.numUpDwn_month_ValueChanged);
            // 
            // numUpDwn_year
            // 
            this.numUpDwn_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDwn_year.Location = new System.Drawing.Point(716, 88);
            this.numUpDwn_year.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numUpDwn_year.Minimum = new decimal(new int[] {
            1601,
            0,
            0,
            0});
            this.numUpDwn_year.Name = "numUpDwn_year";
            this.numUpDwn_year.Size = new System.Drawing.Size(95, 27);
            this.numUpDwn_year.TabIndex = 40;
            this.numUpDwn_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDwn_year.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.numUpDwn_year.ValueChanged += new System.EventHandler(this.numUpDwn_year_ValueChanged);
            // 
            // btn_jobOffer
            // 
            this.btn_jobOffer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_jobOffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jobOffer.ForeColor = System.Drawing.Color.Crimson;
            this.btn_jobOffer.Location = new System.Drawing.Point(1285, 131);
            this.btn_jobOffer.Name = "btn_jobOffer";
            this.btn_jobOffer.Size = new System.Drawing.Size(152, 27);
            this.btn_jobOffer.TabIndex = 41;
            this.btn_jobOffer.Text = "Job offer";
            this.btn_jobOffer.UseVisualStyleBackColor = true;
            this.btn_jobOffer.Click += new System.EventHandler(this.btn_jobOffer_Click);
            // 
            // lbl_dayInMonth
            // 
            this.lbl_dayInMonth.AutoSize = true;
            this.lbl_dayInMonth.BackColor = System.Drawing.Color.White;
            this.lbl_dayInMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dayInMonth.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_dayInMonth.Location = new System.Drawing.Point(555, 91);
            this.lbl_dayInMonth.Name = "lbl_dayInMonth";
            this.lbl_dayInMonth.Size = new System.Drawing.Size(44, 20);
            this.lbl_dayInMonth.TabIndex = 42;
            this.lbl_dayInMonth.Text = "Day:";
            // 
            // txtBox_jobDesc
            // 
            this.txtBox_jobDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_jobDesc.BackColor = System.Drawing.Color.White;
            this.txtBox_jobDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_jobDesc.Location = new System.Drawing.Point(405, 371);
            this.txtBox_jobDesc.Multiline = true;
            this.txtBox_jobDesc.Name = "txtBox_jobDesc";
            this.txtBox_jobDesc.ReadOnly = true;
            this.txtBox_jobDesc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBox_jobDesc.Size = new System.Drawing.Size(1040, 498);
            this.txtBox_jobDesc.TabIndex = 16;
            this.txtBox_jobDesc.Text = "job description:";
            // 
            // groupBox_companySite
            // 
            this.groupBox_companySite.Controls.Add(this.dynamic_lbl_companySite);
            this.groupBox_companySite.Controls.Add(this.txtBox_companySite);
            this.groupBox_companySite.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_companySite.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox_companySite.Location = new System.Drawing.Point(405, 171);
            this.groupBox_companySite.Name = "groupBox_companySite";
            this.groupBox_companySite.Size = new System.Drawing.Size(318, 93);
            this.groupBox_companySite.TabIndex = 43;
            this.groupBox_companySite.TabStop = false;
            this.groupBox_companySite.Text = "company site";
            // 
            // groupBox_companyProfileApp
            // 
            this.groupBox_companyProfileApp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox_companyProfileApp.Controls.Add(this.txtBox_companyProfileApp);
            this.groupBox_companyProfileApp.Controls.Add(this.dynamic_lbl_companyInfo);
            this.groupBox_companyProfileApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_companyProfileApp.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox_companyProfileApp.Location = new System.Drawing.Point(740, 171);
            this.groupBox_companyProfileApp.Name = "groupBox_companyProfileApp";
            this.groupBox_companyProfileApp.Size = new System.Drawing.Size(362, 93);
            this.groupBox_companyProfileApp.TabIndex = 44;
            this.groupBox_companyProfileApp.TabStop = false;
            this.groupBox_companyProfileApp.Text = "company profile app";
            // 
            // groupBox_companyInfo
            // 
            this.groupBox_companyInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_companyInfo.Controls.Add(this.dynamic_lbl_companyProfileApp);
            this.groupBox_companyInfo.Controls.Add(this.txtBox_companyInfo);
            this.groupBox_companyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_companyInfo.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox_companyInfo.Location = new System.Drawing.Point(1119, 171);
            this.groupBox_companyInfo.Name = "groupBox_companyInfo";
            this.groupBox_companyInfo.Size = new System.Drawing.Size(318, 93);
            this.groupBox_companyInfo.TabIndex = 45;
            this.groupBox_companyInfo.TabStop = false;
            this.groupBox_companyInfo.Text = "company info";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(405, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 27);
            this.panel1.TabIndex = 46;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCompanyToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(406, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newCompanyToolStripMenuItem
            // 
            this.newCompanyToolStripMenuItem.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.newCompanyToolStripMenuItem.Name = "newCompanyToolStripMenuItem";
            this.newCompanyToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.newCompanyToolStripMenuItem.Text = "New company";
            this.newCompanyToolStripMenuItem.Click += new System.EventHandler(this.newCompanyToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveInAAditionaltxtFileToolStripMenuItem,
            this.printToolStripMenuItem});
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // saveInAAditionaltxtFileToolStripMenuItem
            // 
            this.saveInAAditionaltxtFileToolStripMenuItem.Name = "saveInAAditionaltxtFileToolStripMenuItem";
            this.saveInAAditionaltxtFileToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.saveInAAditionaltxtFileToolStripMenuItem.Text = "Save as .txt file";
            this.saveInAAditionaltxtFileToolStripMenuItem.Click += new System.EventHandler(this.saveInAditionaltxtFileToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.sourceCodeToolStripMenuItem,
            this.developerToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // sourceCodeToolStripMenuItem
            // 
            this.sourceCodeToolStripMenuItem.Name = "sourceCodeToolStripMenuItem";
            this.sourceCodeToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.sourceCodeToolStripMenuItem.Text = "Source Code";
            this.sourceCodeToolStripMenuItem.Click += new System.EventHandler(this.sourceCodeToolStripMenuItem_Click);
            // 
            // developerToolStripMenuItem
            // 
            this.developerToolStripMenuItem.Name = "developerToolStripMenuItem";
            this.developerToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.developerToolStripMenuItem.Text = "Developer";
            this.developerToolStripMenuItem.Click += new System.EventHandler(this.developerToolStripMenuItem_Click);
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Image = global::JobApplicationLog.Properties.Resources.BackArrow;
            this.btn_back.Location = new System.Drawing.Point(1245, 10);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(34, 28);
            this.btn_back.TabIndex = 31;
            this.toolTip1.SetToolTip(this.btn_back, "Back");
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // picBox_sourceSite
            // 
            this.picBox_sourceSite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox_sourceSite.Location = new System.Drawing.Point(1277, 76);
            this.picBox_sourceSite.Name = "picBox_sourceSite";
            this.picBox_sourceSite.Size = new System.Drawing.Size(160, 50);
            this.picBox_sourceSite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_sourceSite.TabIndex = 36;
            this.picBox_sourceSite.TabStop = false;
            // 
            // btn_restoreStatus
            // 
            this.btn_restoreStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_restoreStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restoreStatus.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_restoreStatus.Location = new System.Drawing.Point(1178, 131);
            this.btn_restoreStatus.Name = "btn_restoreStatus";
            this.btn_restoreStatus.Size = new System.Drawing.Size(259, 27);
            this.btn_restoreStatus.TabIndex = 47;
            this.btn_restoreStatus.Text = "restore default status";
            this.btn_restoreStatus.UseVisualStyleBackColor = true;
            this.btn_restoreStatus.Click += new System.EventHandler(this.btn_restoreStatus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 869);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_companySite);
            this.Controls.Add(this.btn_companyInfo);
            this.Controls.Add(this.btn_companyProfileApp);
            this.Controls.Add(this.groupBox_companyInfo);
            this.Controls.Add(this.groupBox_companyProfileApp);
            this.Controls.Add(this.groupBox_companySite);
            this.Controls.Add(this.txtBox_jobDesc);
            this.Controls.Add(this.lbl_dayInMonth);
            this.Controls.Add(this.btn_jobOffer);
            this.Controls.Add(this.numUpDwn_year);
            this.Controls.Add(this.numUpDwn_month);
            this.Controls.Add(this.btn_deactivateCurrentStatus);
            this.Controls.Add(this.picBox_sourceSite);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txtBox_cons);
            this.Controls.Add(this.txtBox_pros);
            this.Controls.Add(this.txtBox_applicationStatus);
            this.Controls.Add(this.txtBox_sourceSite);
            this.Controls.Add(this.txtBox_companyName);
            this.Controls.Add(this.lbl_applicationStatus);
            this.Controls.Add(this.static_lbl_applicationStatus);
            this.Controls.Add(this.lbl_sourceSite);
            this.Controls.Add(this.static_lbl_sourceSite);
            this.Controls.Add(this.lbl_cons);
            this.Controls.Add(this.lbl_pros);
            this.Controls.Add(this.static_lbl_cons);
            this.Controls.Add(this.static_lbl_pros);
            this.Controls.Add(this.lbl_companyName);
            this.Controls.Add(this.static_lbl_companyName);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.listbox_companies);
            this.Controls.Add(this.numUpDwn_day);
            this.Controls.Add(this.lbl_applicationDate);
            this.Controls.Add(this.static_lbl_applicationDate);
            this.Controls.Add(this.btn_restoreStatus);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1431, 670);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_day)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_month)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_year)).EndInit();
            this.groupBox_companySite.ResumeLayout(false);
            this.groupBox_companySite.PerformLayout();
            this.groupBox_companyProfileApp.ResumeLayout(false);
            this.groupBox_companyProfileApp.PerformLayout();
            this.groupBox_companyInfo.ResumeLayout(false);
            this.groupBox_companyInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_sourceSite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listbox_companies;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_companySite;
        private System.Windows.Forms.Label static_lbl_companyName;
        private System.Windows.Forms.Label lbl_companyName;
        private System.Windows.Forms.Button btn_companyInfo;
        private System.Windows.Forms.Label static_lbl_applicationDate;
        private System.Windows.Forms.Label lbl_applicationDate;
        private System.Windows.Forms.Label static_lbl_pros;
        private System.Windows.Forms.Label static_lbl_cons;
        private System.Windows.Forms.Label lbl_pros;
        private System.Windows.Forms.Label lbl_cons;
        private System.Windows.Forms.Label static_lbl_sourceSite;
        private System.Windows.Forms.Label lbl_sourceSite;
        private System.Windows.Forms.Button btn_companyProfileApp;
        private System.Windows.Forms.Label static_lbl_applicationStatus;
        private System.Windows.Forms.Label lbl_applicationStatus;
        private System.Windows.Forms.TextBox txtBox_companyName;
        private System.Windows.Forms.TextBox txtBox_sourceSite;
        private System.Windows.Forms.TextBox txtBox_applicationStatus;
        private System.Windows.Forms.TextBox txtBox_companySite;
        private System.Windows.Forms.TextBox txtBox_companyProfileApp;
        private System.Windows.Forms.TextBox txtBox_companyInfo;
        private System.Windows.Forms.TextBox txtBox_pros;
        private System.Windows.Forms.TextBox txtBox_cons;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label dynamic_lbl_companySite;
        private System.Windows.Forms.Label dynamic_lbl_companyInfo;
        private System.Windows.Forms.Label dynamic_lbl_companyProfileApp;
        private System.Windows.Forms.PictureBox picBox_sourceSite;
        private System.Windows.Forms.Button btn_deactivateCurrentStatus;
        private System.Windows.Forms.NumericUpDown numUpDwn_day;
        private System.Windows.Forms.NumericUpDown numUpDwn_month;
        private System.Windows.Forms.NumericUpDown numUpDwn_year;
        private System.Windows.Forms.Button btn_jobOffer;
        private System.Windows.Forms.Label lbl_dayInMonth;
        private System.Windows.Forms.TextBox txtBox_jobDesc;
        private System.Windows.Forms.GroupBox groupBox_companySite;
        private System.Windows.Forms.GroupBox groupBox_companyProfileApp;
        private System.Windows.Forms.GroupBox groupBox_companyInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newCompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveInAAditionaltxtFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developerToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem sourceCodeToolStripMenuItem;
        private System.Windows.Forms.Button btn_restoreStatus;
    }
}

