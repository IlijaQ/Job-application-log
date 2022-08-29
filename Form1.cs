using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JobApplicationLog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ReloadRecentList();

            //PopulateUi();

            txtBox_companyName.Hide();
            txtBox_applicationDate.Hide();
            txtBox_applicationStatus.Hide();
            txtBox_sourceSite.Hide();
            txtBox_companySite.Hide();
            txtBox_companyProfileApp.Hide();
            txtBox_companyInfo.Hide();
            txtBox_pros.Hide();
            txtBox_cons.Hide();
        }

        private void ReloadRecentList()
        {
            listbox_companies.Items.Clear();
            string[] companiesList = File.ReadAllLines("CompaniesList.txt");
            listbox_companies.Items.AddRange(companiesList);
        }

        Company Company1 = new Company();

        //List<string> linesList = new List<string>();
        //string selectedFile = "TestCompany.txt";
        

        public void btn_edit_Click(object sender, EventArgs e)
        {
            //Form2 form2 = new Form2(Company1);
            //form2.Show();

            #region Replace Info with TextBoxes for data edit
            lbl_companyName.Hide();
            txtBox_companyName.Show();

            lbl_applicationDate.Hide();
            txtBox_applicationDate.Show();

            lbl_applicationStatus.Hide();
            txtBox_applicationStatus.Show();

            lbl_sourceSite.Hide();
            txtBox_sourceSite.Show();

            btn_companySite.Hide();
            txtBox_companySite.Show();

            btn_companyProfileApp.Hide();
            txtBox_companyProfileApp.Show();

            btn_companyInfo.Hide();
            txtBox_companyInfo.Show();

            lbl_pros.Hide();
            txtBox_pros.Show();

            lbl_cons.Hide();
            txtBox_cons.Show();
            #endregion

            #region Populates TextBoxes with appropriate values
            txtBox_companyName.Text = Company1.CompanyName;
            txtBox_applicationDate.Text = Company1.ApplicationDate;
            txtBox_applicationStatus.Text = Company1.ApplicationStatus;
            txtBox_sourceSite.Text = Company1.SourceSite;
            txtBox_companySite.Text = Company1.CompanySiteLink;
            txtBox_companyProfileApp.Text = Company1.CompanyProfileAppLink;
            txtBox_companyInfo.Text = Company1.CompanyInfoLink;
            txtBox_pros.Text = Company1.Pros;
            txtBox_cons.Text = Company1.Cons; 
            #endregion

        }

        private void btn_openCompany_Click(object sender, EventArgs e)
        {
            


            PopulateUi((string)listbox_companies.SelectedItem);
        }

        

        private void PopulateUi(string selectedFile)
        {


            string[] linesArray = File.ReadAllLines(selectedFile);
            List<string> linesList = new List<string>();
            linesList.AddRange(linesArray);

            #region Loading Data
            //ucitavanje infa sa lokalnog
            Company1.CompanyName = linesList[0];
            Company1.ApplicationDate = linesList[1];
            Company1.SourceSite = linesList[2];
            Company1.ApplicationStatus = linesList[3];
            Company1.CompanySiteLink = linesList[4];
            Company1.CompanyProfileAppLink = linesList[5];
            Company1.CompanyInfoLink = linesList[6];
            Company1.Pros = linesList[7];
            Company1.Cons = linesList[8];

            Company1.JobDescription = linesList;
            Company1.JobDescription.RemoveRange(0, 9);

            //List<string> LinesForJobDescription = Company1.JobDescription;
            //LinesForJobDescription.

            lbl_companyName.Text = Company1.CompanyName;
            lbl_applicationDate.Text = Company1.ApplicationDate;
            lbl_sourceSite.Text = Company1.SourceSite;
            lbl_applicationStatus.Text = Company1.ApplicationStatus;

            if (String.IsNullOrEmpty(Company1.CompanyProfileAppLink))
            {
                btn_companyProfileApp.Hide();
            }

            lbl_pros.Text = Company1.Pros;
            lbl_cons.Text = Company1.Cons;

            txtBox_jobDesc.Text = "";

            for (int i = 0; i < Company1.JobDescription.Count; i++) //adds new line in last textbox for every item from position 4 to the end of the array
            {

                txtBox_jobDesc.Text = txtBox_jobDesc.Text + Company1.JobDescription[i];
                if (i < Company1.JobDescription.Count - 1) //prevents adding an empty line at the end of textbox content
                {
                    txtBox_jobDesc.Text = txtBox_jobDesc.Text + "\r\n";
                }
            }
            #endregion
        }

        private void btn_companySite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Company1.CompanySiteLink);
        }

        private void btn_companyProfileApp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Company1.CompanyProfileAppLink);
        }

        private void btn_companyInfo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Company1.CompanyInfoLink);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            HidesSingleLineTextboxes();
        }

        private void HidesSingleLineTextboxes()
        {
            lbl_companyName.Show();
            txtBox_companyName.Hide();

            lbl_applicationDate.Show();
            txtBox_applicationDate.Hide();

            lbl_applicationStatus.Show();
            txtBox_applicationStatus.Hide();

            lbl_sourceSite.Show();
            txtBox_sourceSite.Hide();

            btn_companySite.Show();
            txtBox_companySite.Hide();

            btn_companyProfileApp.Show();
            txtBox_companyProfileApp.Hide();

            btn_companyInfo.Show();
            txtBox_companyInfo.Hide();

            lbl_pros.Show();
            txtBox_pros.Hide();

            lbl_cons.Show();
            txtBox_cons.Hide();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            HidesSingleLineTextboxes();

            Company1.CompanyName = txtBox_companyName.Text;
            Company1.ApplicationDate = txtBox_applicationDate.Text;
            Company1.ApplicationStatus = txtBox_applicationStatus.Text;
            Company1.SourceSite = txtBox_sourceSite.Text;
            Company1.CompanySiteLink = txtBox_companySite.Text;
            Company1.CompanyProfileAppLink = txtBox_companyProfileApp.Text;
            Company1.CompanyInfoLink = txtBox_companyInfo.Text;
            Company1.Pros = txtBox_pros.Text;
            Company1.Cons = txtBox_cons.Text;

            //File.WriteAllLines

        }

        
    }
}
