
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
            this.SuspendLayout();
            // 
            // listbox_companies
            // 
            this.listbox_companies.FormattingEnabled = true;
            this.listbox_companies.ItemHeight = 16;
            this.listbox_companies.Location = new System.Drawing.Point(12, 52);
            this.listbox_companies.MultiColumn = true;
            this.listbox_companies.Name = "listbox_companies";
            this.listbox_companies.Size = new System.Drawing.Size(198, 820);
            this.listbox_companies.TabIndex = 0;
            // 
            // btn_newCompany
            // 
            this.btn_newCompany.Location = new System.Drawing.Point(259, 12);
            this.btn_newCompany.Name = "btn_newCompany";
            this.btn_newCompany.Size = new System.Drawing.Size(198, 23);
            this.btn_newCompany.TabIndex = 1;
            this.btn_newCompany.Text = "new company";
            this.btn_newCompany.UseVisualStyleBackColor = true;
            // 
            // btn_openCompany
            // 
            this.btn_openCompany.Location = new System.Drawing.Point(12, 12);
            this.btn_openCompany.Name = "btn_openCompany";
            this.btn_openCompany.Size = new System.Drawing.Size(198, 23);
            this.btn_openCompany.TabIndex = 2;
            this.btn_openCompany.Text = "open company";
            this.btn_openCompany.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(811, 12);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(198, 23);
            this.btn_edit.TabIndex = 3;
            this.btn_edit.Text = "edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_companySite
            // 
            this.btn_companySite.Location = new System.Drawing.Point(259, 213);
            this.btn_companySite.Name = "btn_companySite";
            this.btn_companySite.Size = new System.Drawing.Size(310, 23);
            this.btn_companySite.TabIndex = 4;
            this.btn_companySite.Text = "company site";
            this.btn_companySite.UseVisualStyleBackColor = true;
            // 
            // static_lbl_companyName
            // 
            this.static_lbl_companyName.AutoSize = true;
            this.static_lbl_companyName.Location = new System.Drawing.Point(256, 60);
            this.static_lbl_companyName.Name = "static_lbl_companyName";
            this.static_lbl_companyName.Size = new System.Drawing.Size(108, 17);
            this.static_lbl_companyName.TabIndex = 5;
            this.static_lbl_companyName.Text = "company name:";
            // 
            // lbl_companyName
            // 
            this.lbl_companyName.AutoSize = true;
            this.lbl_companyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_companyName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_companyName.Location = new System.Drawing.Point(365, 53);
            this.lbl_companyName.Name = "lbl_companyName";
            this.lbl_companyName.Size = new System.Drawing.Size(158, 25);
            this.lbl_companyName.TabIndex = 6;
            this.lbl_companyName.Text = "company name";
            // 
            // btn_companyInfo
            // 
            this.btn_companyInfo.Location = new System.Drawing.Point(699, 213);
            this.btn_companyInfo.Name = "btn_companyInfo";
            this.btn_companyInfo.Size = new System.Drawing.Size(310, 23);
            this.btn_companyInfo.TabIndex = 7;
            this.btn_companyInfo.Text = "company info";
            this.btn_companyInfo.UseVisualStyleBackColor = true;
            // 
            // static_lbl_applicationDate
            // 
            this.static_lbl_applicationDate.AutoSize = true;
            this.static_lbl_applicationDate.Location = new System.Drawing.Point(256, 106);
            this.static_lbl_applicationDate.Name = "static_lbl_applicationDate";
            this.static_lbl_applicationDate.Size = new System.Drawing.Size(112, 17);
            this.static_lbl_applicationDate.TabIndex = 8;
            this.static_lbl_applicationDate.Text = "application date:";
            // 
            // lbl_applicationDate
            // 
            this.lbl_applicationDate.AutoSize = true;
            this.lbl_applicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_applicationDate.Location = new System.Drawing.Point(367, 104);
            this.lbl_applicationDate.Name = "lbl_applicationDate";
            this.lbl_applicationDate.Size = new System.Drawing.Size(126, 18);
            this.lbl_applicationDate.TabIndex = 9;
            this.lbl_applicationDate.Text = "application date";
            // 
            // static_lbl_pros
            // 
            this.static_lbl_pros.AutoSize = true;
            this.static_lbl_pros.Location = new System.Drawing.Point(256, 268);
            this.static_lbl_pros.Name = "static_lbl_pros";
            this.static_lbl_pros.Size = new System.Drawing.Size(40, 17);
            this.static_lbl_pros.TabIndex = 12;
            this.static_lbl_pros.Text = "pros:";
            // 
            // static_lbl_cons
            // 
            this.static_lbl_cons.AutoSize = true;
            this.static_lbl_cons.Location = new System.Drawing.Point(256, 314);
            this.static_lbl_cons.Name = "static_lbl_cons";
            this.static_lbl_cons.Size = new System.Drawing.Size(42, 17);
            this.static_lbl_cons.TabIndex = 13;
            this.static_lbl_cons.Text = "cons:";
            // 
            // lbl_pros
            // 
            this.lbl_pros.AutoSize = true;
            this.lbl_pros.Location = new System.Drawing.Point(367, 268);
            this.lbl_pros.Name = "lbl_pros";
            this.lbl_pros.Size = new System.Drawing.Size(36, 17);
            this.lbl_pros.TabIndex = 14;
            this.lbl_pros.Text = "pros";
            // 
            // lbl_cons
            // 
            this.lbl_cons.AutoSize = true;
            this.lbl_cons.Location = new System.Drawing.Point(367, 314);
            this.lbl_cons.Name = "lbl_cons";
            this.lbl_cons.Size = new System.Drawing.Size(38, 17);
            this.lbl_cons.TabIndex = 15;
            this.lbl_cons.Text = "cons";
            // 
            // txtBox_jobDesc
            // 
            this.txtBox_jobDesc.Location = new System.Drawing.Point(259, 371);
            this.txtBox_jobDesc.Multiline = true;
            this.txtBox_jobDesc.Name = "txtBox_jobDesc";
            this.txtBox_jobDesc.Size = new System.Drawing.Size(750, 504);
            this.txtBox_jobDesc.TabIndex = 16;
            this.txtBox_jobDesc.Text = "job description:";
            // 
            // static_lbl_sourceSite
            // 
            this.static_lbl_sourceSite.AutoSize = true;
            this.static_lbl_sourceSite.Location = new System.Drawing.Point(808, 106);
            this.static_lbl_sourceSite.Name = "static_lbl_sourceSite";
            this.static_lbl_sourceSite.Size = new System.Drawing.Size(81, 17);
            this.static_lbl_sourceSite.TabIndex = 17;
            this.static_lbl_sourceSite.Text = "source site:";
            // 
            // lbl_sourceSite
            // 
            this.lbl_sourceSite.AutoSize = true;
            this.lbl_sourceSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sourceSite.Location = new System.Drawing.Point(895, 104);
            this.lbl_sourceSite.Name = "lbl_sourceSite";
            this.lbl_sourceSite.Size = new System.Drawing.Size(92, 18);
            this.lbl_sourceSite.TabIndex = 18;
            this.lbl_sourceSite.Text = "source site";
            // 
            // btn_companyProfileApp
            // 
            this.btn_companyProfileApp.Location = new System.Drawing.Point(597, 213);
            this.btn_companyProfileApp.Name = "btn_companyProfileApp";
            this.btn_companyProfileApp.Size = new System.Drawing.Size(75, 23);
            this.btn_companyProfileApp.TabIndex = 19;
            this.btn_companyProfileApp.Text = "profile";
            this.btn_companyProfileApp.UseVisualStyleBackColor = true;
            // 
            // static_lbl_applicationStatus
            // 
            this.static_lbl_applicationStatus.AutoSize = true;
            this.static_lbl_applicationStatus.Location = new System.Drawing.Point(256, 155);
            this.static_lbl_applicationStatus.Name = "static_lbl_applicationStatus";
            this.static_lbl_applicationStatus.Size = new System.Drawing.Size(50, 17);
            this.static_lbl_applicationStatus.TabIndex = 20;
            this.static_lbl_applicationStatus.Text = "status:";
            // 
            // lbl_applicationStatus
            // 
            this.lbl_applicationStatus.AutoSize = true;
            this.lbl_applicationStatus.Location = new System.Drawing.Point(367, 155);
            this.lbl_applicationStatus.Name = "lbl_applicationStatus";
            this.lbl_applicationStatus.Size = new System.Drawing.Size(118, 17);
            this.lbl_applicationStatus.TabIndex = 21;
            this.lbl_applicationStatus.Text = "application status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 887);
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
            this.Controls.Add(this.lbl_applicationDate);
            this.Controls.Add(this.static_lbl_applicationDate);
            this.Controls.Add(this.btn_companyInfo);
            this.Controls.Add(this.lbl_companyName);
            this.Controls.Add(this.static_lbl_companyName);
            this.Controls.Add(this.btn_companySite);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_openCompany);
            this.Controls.Add(this.btn_newCompany);
            this.Controls.Add(this.listbox_companies);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

