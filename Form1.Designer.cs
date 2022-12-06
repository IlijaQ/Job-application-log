
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
            this.listbox_companies = new System.Windows.Forms.ListBox();
            this.btn_newCompany = new System.Windows.Forms.Button();
            this.btn_openCompany = new System.Windows.Forms.Button();
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
            this.txtBox_jobDesc = new System.Windows.Forms.TextBox();
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
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.dynamic_lbl_companySite = new System.Windows.Forms.Label();
            this.dynamic_lbl_companyInfo = new System.Windows.Forms.Label();
            this.dynamic_lbl_companyProfileApp = new System.Windows.Forms.Label();
            this.picBox_sourceSite = new System.Windows.Forms.PictureBox();
            this.btn_deactivateCurrentStatus = new System.Windows.Forms.Button();
            this.numUpDwn_day = new System.Windows.Forms.NumericUpDown();
            this.numUpDwn_month = new System.Windows.Forms.NumericUpDown();
            this.numUpDwn_year = new System.Windows.Forms.NumericUpDown();
            this.btn_jobOffer = new System.Windows.Forms.Button();
            this.lbl_dayInMonth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_sourceSite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_day)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_month)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_year)).BeginInit();
            this.SuspendLayout();
            // 
            // listbox_companies
            // 
            this.listbox_companies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_companies.FormattingEnabled = true;
            this.listbox_companies.ItemHeight = 20;
            this.listbox_companies.Location = new System.Drawing.Point(12, 52);
            this.listbox_companies.MultiColumn = true;
            this.listbox_companies.Name = "listbox_companies";
            this.listbox_companies.Size = new System.Drawing.Size(387, 804);
            this.listbox_companies.TabIndex = 0;
            // 
            // btn_newCompany
            // 
            this.btn_newCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newCompany.Location = new System.Drawing.Point(409, 9);
            this.btn_newCompany.Name = "btn_newCompany";
            this.btn_newCompany.Size = new System.Drawing.Size(198, 28);
            this.btn_newCompany.TabIndex = 1;
            this.btn_newCompany.Text = "new company";
            this.btn_newCompany.UseVisualStyleBackColor = true;
            this.btn_newCompany.Click += new System.EventHandler(this.btn_newCompany_Click);
            // 
            // btn_openCompany
            // 
            this.btn_openCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_openCompany.Location = new System.Drawing.Point(12, 9);
            this.btn_openCompany.Name = "btn_openCompany";
            this.btn_openCompany.Size = new System.Drawing.Size(198, 28);
            this.btn_openCompany.TabIndex = 2;
            this.btn_openCompany.Text = "open company";
            this.btn_openCompany.UseVisualStyleBackColor = true;
            this.btn_openCompany.Click += new System.EventHandler(this.btn_openCompany_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(1235, 9);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(198, 28);
            this.btn_edit.TabIndex = 3;
            this.btn_edit.Text = "edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_companySite
            // 
            this.btn_companySite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_companySite.Location = new System.Drawing.Point(409, 212);
            this.btn_companySite.Name = "btn_companySite";
            this.btn_companySite.Size = new System.Drawing.Size(310, 28);
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
            this.btn_companyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_companyInfo.Location = new System.Drawing.Point(1123, 212);
            this.btn_companyInfo.Name = "btn_companyInfo";
            this.btn_companyInfo.Size = new System.Drawing.Size(310, 27);
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
            // txtBox_jobDesc
            // 
            this.txtBox_jobDesc.BackColor = System.Drawing.Color.White;
            this.txtBox_jobDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_jobDesc.Location = new System.Drawing.Point(409, 366);
            this.txtBox_jobDesc.Multiline = true;
            this.txtBox_jobDesc.Name = "txtBox_jobDesc";
            this.txtBox_jobDesc.ReadOnly = true;
            this.txtBox_jobDesc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBox_jobDesc.Size = new System.Drawing.Size(1024, 470);
            this.txtBox_jobDesc.TabIndex = 16;
            this.txtBox_jobDesc.Text = "job description:";
            // 
            // static_lbl_sourceSite
            // 
            this.static_lbl_sourceSite.AutoSize = true;
            this.static_lbl_sourceSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.static_lbl_sourceSite.Location = new System.Drawing.Point(1170, 96);
            this.static_lbl_sourceSite.Name = "static_lbl_sourceSite";
            this.static_lbl_sourceSite.Size = new System.Drawing.Size(97, 20);
            this.static_lbl_sourceSite.TabIndex = 17;
            this.static_lbl_sourceSite.Text = "source site:";
            // 
            // lbl_sourceSite
            // 
            this.lbl_sourceSite.AutoSize = true;
            this.lbl_sourceSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sourceSite.Location = new System.Drawing.Point(1281, 96);
            this.lbl_sourceSite.Name = "lbl_sourceSite";
            this.lbl_sourceSite.Size = new System.Drawing.Size(103, 20);
            this.lbl_sourceSite.TabIndex = 18;
            this.lbl_sourceSite.Text = "source site";
            // 
            // btn_companyProfileApp
            // 
            this.btn_companyProfileApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_companyProfileApp.Location = new System.Drawing.Point(829, 212);
            this.btn_companyProfileApp.Name = "btn_companyProfileApp";
            this.btn_companyProfileApp.Size = new System.Drawing.Size(197, 27);
            this.btn_companyProfileApp.TabIndex = 19;
            this.btn_companyProfileApp.Text = "profile";
            this.btn_companyProfileApp.UseVisualStyleBackColor = true;
            this.btn_companyProfileApp.Click += new System.EventHandler(this.btn_companyProfileApp_Click);
            // 
            // static_lbl_applicationStatus
            // 
            this.static_lbl_applicationStatus.AutoSize = true;
            this.static_lbl_applicationStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.static_lbl_applicationStatus.Location = new System.Drawing.Point(405, 145);
            this.static_lbl_applicationStatus.Name = "static_lbl_applicationStatus";
            this.static_lbl_applicationStatus.Size = new System.Drawing.Size(60, 20);
            this.static_lbl_applicationStatus.TabIndex = 20;
            this.static_lbl_applicationStatus.Text = "status:";
            // 
            // lbl_applicationStatus
            // 
            this.lbl_applicationStatus.AutoSize = true;
            this.lbl_applicationStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_applicationStatus.Location = new System.Drawing.Point(548, 145);
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
            this.txtBox_sourceSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_sourceSite.Location = new System.Drawing.Point(1281, 88);
            this.txtBox_sourceSite.Name = "txtBox_sourceSite";
            this.txtBox_sourceSite.Size = new System.Drawing.Size(152, 27);
            this.txtBox_sourceSite.TabIndex = 24;
            // 
            // txtBox_applicationStatus
            // 
            this.txtBox_applicationStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_applicationStatus.Location = new System.Drawing.Point(552, 138);
            this.txtBox_applicationStatus.Name = "txtBox_applicationStatus";
            this.txtBox_applicationStatus.Size = new System.Drawing.Size(616, 27);
            this.txtBox_applicationStatus.TabIndex = 25;
            // 
            // txtBox_companySite
            // 
            this.txtBox_companySite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_companySite.Location = new System.Drawing.Point(409, 172);
            this.txtBox_companySite.Name = "txtBox_companySite";
            this.txtBox_companySite.Size = new System.Drawing.Size(1024, 27);
            this.txtBox_companySite.TabIndex = 26;
            // 
            // txtBox_companyProfileApp
            // 
            this.txtBox_companyProfileApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_companyProfileApp.Location = new System.Drawing.Point(409, 238);
            this.txtBox_companyProfileApp.Name = "txtBox_companyProfileApp";
            this.txtBox_companyProfileApp.Size = new System.Drawing.Size(1024, 27);
            this.txtBox_companyProfileApp.TabIndex = 27;
            // 
            // txtBox_companyInfo
            // 
            this.txtBox_companyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_companyInfo.Location = new System.Drawing.Point(409, 205);
            this.txtBox_companyInfo.Name = "txtBox_companyInfo";
            this.txtBox_companyInfo.Size = new System.Drawing.Size(1024, 27);
            this.txtBox_companyInfo.TabIndex = 28;
            // 
            // txtBox_pros
            // 
            this.txtBox_pros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_pros.Location = new System.Drawing.Point(552, 271);
            this.txtBox_pros.Name = "txtBox_pros";
            this.txtBox_pros.Size = new System.Drawing.Size(881, 27);
            this.txtBox_pros.TabIndex = 29;
            // 
            // txtBox_cons
            // 
            this.txtBox_cons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_cons.Location = new System.Drawing.Point(552, 318);
            this.txtBox_cons.Name = "txtBox_cons";
            this.txtBox_cons.Size = new System.Drawing.Size(881, 27);
            this.txtBox_cons.TabIndex = 30;
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(409, 9);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(198, 28);
            this.btn_back.TabIndex = 31;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(1235, 9);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(198, 28);
            this.btn_save.TabIndex = 32;
            this.btn_save.Text = "save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dynamic_lbl_companySite
            // 
            this.dynamic_lbl_companySite.BackColor = System.Drawing.SystemColors.Control;
            this.dynamic_lbl_companySite.Location = new System.Drawing.Point(176, 172);
            this.dynamic_lbl_companySite.Name = "dynamic_lbl_companySite";
            this.dynamic_lbl_companySite.Size = new System.Drawing.Size(200, 27);
            this.dynamic_lbl_companySite.TabIndex = 33;
            this.dynamic_lbl_companySite.Text = "company site";
            this.dynamic_lbl_companySite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dynamic_lbl_companyInfo
            // 
            this.dynamic_lbl_companyInfo.BackColor = System.Drawing.SystemColors.Control;
            this.dynamic_lbl_companyInfo.Location = new System.Drawing.Point(176, 205);
            this.dynamic_lbl_companyInfo.Name = "dynamic_lbl_companyInfo";
            this.dynamic_lbl_companyInfo.Size = new System.Drawing.Size(200, 27);
            this.dynamic_lbl_companyInfo.TabIndex = 34;
            this.dynamic_lbl_companyInfo.Text = "company info";
            this.dynamic_lbl_companyInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dynamic_lbl_companyProfileApp
            // 
            this.dynamic_lbl_companyProfileApp.BackColor = System.Drawing.SystemColors.Control;
            this.dynamic_lbl_companyProfileApp.Location = new System.Drawing.Point(176, 238);
            this.dynamic_lbl_companyProfileApp.Name = "dynamic_lbl_companyProfileApp";
            this.dynamic_lbl_companyProfileApp.Size = new System.Drawing.Size(200, 27);
            this.dynamic_lbl_companyProfileApp.TabIndex = 35;
            this.dynamic_lbl_companyProfileApp.Text = "company profile app";
            this.dynamic_lbl_companyProfileApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBox_sourceSite
            // 
            this.picBox_sourceSite.Location = new System.Drawing.Point(1273, 75);
            this.picBox_sourceSite.Name = "picBox_sourceSite";
            this.picBox_sourceSite.Size = new System.Drawing.Size(160, 50);
            this.picBox_sourceSite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_sourceSite.TabIndex = 36;
            this.picBox_sourceSite.TabStop = false;
            // 
            // btn_deactivateCurrentStatus
            // 
            this.btn_deactivateCurrentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deactivateCurrentStatus.Location = new System.Drawing.Point(1174, 138);
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
            this.btn_jobOffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jobOffer.ForeColor = System.Drawing.Color.Crimson;
            this.btn_jobOffer.Location = new System.Drawing.Point(1281, 138);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 869);
            this.Controls.Add(this.lbl_dayInMonth);
            this.Controls.Add(this.btn_jobOffer);
            this.Controls.Add(this.numUpDwn_year);
            this.Controls.Add(this.numUpDwn_month);
            this.Controls.Add(this.btn_deactivateCurrentStatus);
            this.Controls.Add(this.picBox_sourceSite);
            this.Controls.Add(this.dynamic_lbl_companyProfileApp);
            this.Controls.Add(this.dynamic_lbl_companyInfo);
            this.Controls.Add(this.dynamic_lbl_companySite);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txtBox_cons);
            this.Controls.Add(this.txtBox_pros);
            this.Controls.Add(this.txtBox_companyInfo);
            this.Controls.Add(this.txtBox_companyProfileApp);
            this.Controls.Add(this.txtBox_companySite);
            this.Controls.Add(this.txtBox_applicationStatus);
            this.Controls.Add(this.txtBox_sourceSite);
            this.Controls.Add(this.txtBox_companyName);
            this.Controls.Add(this.lbl_applicationStatus);
            this.Controls.Add(this.static_lbl_applicationStatus);
            this.Controls.Add(this.btn_companyProfileApp);
            this.Controls.Add(this.lbl_sourceSite);
            this.Controls.Add(this.static_lbl_sourceSite);
            this.Controls.Add(this.txtBox_jobDesc);
            this.Controls.Add(this.lbl_cons);
            this.Controls.Add(this.lbl_pros);
            this.Controls.Add(this.static_lbl_cons);
            this.Controls.Add(this.static_lbl_pros);
            this.Controls.Add(this.btn_companyInfo);
            this.Controls.Add(this.lbl_companyName);
            this.Controls.Add(this.static_lbl_companyName);
            this.Controls.Add(this.btn_companySite);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_openCompany);
            this.Controls.Add(this.btn_newCompany);
            this.Controls.Add(this.listbox_companies);
            this.Controls.Add(this.numUpDwn_day);
            this.Controls.Add(this.lbl_applicationDate);
            this.Controls.Add(this.static_lbl_applicationDate);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_sourceSite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_day)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_month)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_year)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listbox_companies;
        private System.Windows.Forms.Button btn_newCompany;
        private System.Windows.Forms.Button btn_openCompany;
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
        private System.Windows.Forms.TextBox txtBox_jobDesc;
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
    }
}

