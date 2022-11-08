using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApplicationLog
{
    public partial class Form2 : Form
    {
        Company Company2 = new Company();
        

        public Form2(Company co)
        {
            InitializeComponent();

            Company2.CompanyName = co.CompanyName;
            Company2.ApplicationDate = co.ApplicationDate;
            Company2.SourceSite = co.SourceSite;
            Company2.ApplicationStatus = co.ApplicationStatus;
            Company2.CompanySiteLink = co.CompanySiteLink;
            Company2.CompanyInfoLink = co.CompanyInfoLink;
            Company2.CompanyProfileAppLink = co.CompanyProfileAppLink;
            Company2.Pros = co.Pros;
            Company2.Cons = co.Cons;

            Company2.JobDescription = co.JobDescription;

            PopulateUi();
        }

        

        private void PopulateUi()
        {
            txtBox_companyName.Text = Company2.CompanyName;
            txtBox_applicationDate.Text = Company2.ApplicationDate.ToString("dd.M.yyyy");
            txtBox_sourceSite.Text = Company2.SourceSite;
            txtBox_applicationStatus.Text = Company2.ApplicationStatus;
            txtBox_companySite.Text = Company2.CompanySiteLink;
            txtBox_companyProfileApp.Text = Company2.CompanySiteLink;
            txtBox_companyInfo.Text = Company2.CompanyInfoLink;
            txtBox_pros.Text = Company2.Pros;
            txtBox_cons.Text = Company2.Cons;

            for (int i = 0; i < Company2.JobDescription.Count; i++) //adds new line in last textbox for every item from position 4 to the end of the array
            {

                txtBox_jobDesc2.Text = txtBox_jobDesc2.Text + Company2.JobDescription[i];
                if (i < Company2.JobDescription.Count - 1) //prevents adding an empty line at the end of textbox content
                {
                    txtBox_jobDesc2.Text = txtBox_jobDesc2.Text + "\r\n";
                }
            }

        }




        private void btn_save_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_backToForm1_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
