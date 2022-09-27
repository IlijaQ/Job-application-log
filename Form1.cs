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
            
            PopulateUi(companiesDictionary[(string)listbox_companies.Items[0]]);
            
            HidesSingleLineTextboxes();
            
        }

        Company Company1 = new Company();
        Dictionary<string, string> companiesDictionary = new Dictionary<string, string>();

        private void ReloadRecentList()
        {
            listbox_companies.Items.Clear();
            companiesDictionary.Clear();
            string[] companiesArray = File.ReadAllLines("CompaniesList.txt");

            List<string> companiesList = new List<string>();
            

            for(int i = 0; i < companiesArray.Length; i+=2)
            {
                //Cheks for empty entries. They apper when user exits a dialog box when prompted to save a new file.
                if (!string.IsNullOrEmpty(companiesArray[i]))
                {
                    companiesList.Add(companiesArray[i]);

                    companiesDictionary.Add(companiesArray[i], companiesArray[i + 1]);
                }
                else
                {
                    i--;
                }
            }
            companiesList.Reverse();

            string[] arrayForUi = companiesList.ToArray();
            //Array.Reverse(companiesArray, 0, companiesArray.Length);
            listbox_companies.Items.AddRange(arrayForUi);
        }

        
        //List<string> linesList = new List<string>();
        //string selectedFile = "TestCompany.txt";
        

        public void btn_edit_Click(object sender, EventArgs e)
        {
            //Form2 form2 = new Form2(Company1);
            //form2.Show();


            ReplaceLabelsWithTextboxes();
            

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
            PopulatesJobDesc();
            #endregion

        }

        private void ReplaceLabelsWithTextboxes()//and replaces 'new company' and 'edit' buttons with 'back' and 'save'
        {
            lbl_companyName.Hide();
            txtBox_companyName.Show();

            lbl_applicationDate.Hide();
            txtBox_applicationDate.Show();

            lbl_applicationStatus.Hide();
            txtBox_applicationStatus.Show();

            if (Company1.currentStatus)
            {
                btn_deactivateCurrentStatus.Show();
                btn_deactivateCurrentStatus.Text = "deactivate";
            }
            

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

            dynamic_lbl_companySite.Show();
            dynamic_lbl_companyInfo.Show();
            dynamic_lbl_companyProfileApp.Show();

            btn_newCompany.Hide();
            btn_edit.Hide();
            btn_back.Show();
            btn_save.Show();

            picBox_sourceSite.Hide();
        }

        private void btn_openCompany_Click(object sender, EventArgs e)
        {
            Company1.FilePath = (string)listbox_companies.SelectedItem;


            PopulateUi(companiesDictionary[(string)listbox_companies.SelectedItem]);
        }

        

        private void PopulateUi(string selectedFile)
        {
            Company1.FilePath = selectedFile;

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

            if (linesList[9] == "1")
            {
                Company1.currentStatus = true;
                lbl_companyName.ForeColor = Color.FromArgb(51, 153, 255);
            }
            else if(linesList[9] == "0")
            {
                Company1.currentStatus = false;
                lbl_companyName.ForeColor = Color.Gray;
            }

            Company1.JobDescription = linesList;
            Company1.JobDescription.RemoveRange(0, 10);

            //List<string> LinesForJobDescription = Company1.JobDescription;
            //LinesForJobDescription.

            lbl_companyName.Text = Company1.CompanyName;
            lbl_applicationDate.Text = Company1.ApplicationDate;
            lbl_sourceSite.Text = Company1.SourceSite;


            #region Determins wheader to put a logo of source site instead of text

            DeterminTextOrPicture();
            //loads apropriate picture
            if (Company1.SourceSite.ToLower() == "joberty")
            {
                picBox_sourceSite.Image = new Bitmap("JobertyLogo.png");
            }
            else if (Company1.SourceSite.ToLower().Contains("helloworld"))
            {
                picBox_sourceSite.Image = new Bitmap("HelloWorldLogo.png");
            }
            else if (Company1.SourceSite.ToLower() == "infostud")
            {
                picBox_sourceSite.Image = new Bitmap("InfostudLogo.png");
            }
            else if (Company1.SourceSite.ToLower() == "linkedin")
            {
                picBox_sourceSite.Image = new Bitmap("LinkedInLogo.png");
            }

            #endregion


            lbl_applicationStatus.Text = Company1.ApplicationStatus;

            if (String.IsNullOrEmpty(Company1.CompanyProfileAppLink))
            {
                btn_companyProfileApp.Hide();
            }
            else
            {
                btn_companyProfileApp.Show();
            }

            lbl_pros.Text = Company1.Pros;
            lbl_cons.Text = Company1.Cons;

            PopulatesJobDesc();
            #endregion
        }

        private void DeterminTextOrPicture()
        {
            //determins weather to show text or picture for source site
            if (Company1.SourceSite.ToLower() == "joberty" || Company1.SourceSite.ToLower().Contains("helloworld") || Company1.SourceSite.ToLower() == "infostud" || Company1.SourceSite.ToLower() == "linkedin")
            {
                lbl_sourceSite.Hide();
                picBox_sourceSite.Show();
            }
            else
            {
                lbl_sourceSite.Show();
                picBox_sourceSite.Hide();
            }
        }

        private void PopulatesJobDesc()
        {
            txtBox_jobDesc.Text = "";

            for (int i = 0; i < Company1.JobDescription.Count; i++) //adds new line in last textbox for every item from position 4 to the end of the array
            {

                txtBox_jobDesc.Text = txtBox_jobDesc.Text + Company1.JobDescription[i];
                if (i < Company1.JobDescription.Count - 1) //prevents adding an empty line at the end of textbox content
                {
                    txtBox_jobDesc.Text = txtBox_jobDesc.Text + "\r\n";
                }
            }
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
            PopulatesJobDesc();
            
            
        }

        private void HidesSingleLineTextboxes()//and replaces 'back' and 'save' with 'new' and 'edit' button
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

            if (!string.IsNullOrEmpty(Company1.CompanyProfileAppLink))
            {
                btn_companyProfileApp.Show();
            }
            txtBox_companyProfileApp.Hide();

            btn_companyInfo.Show();
            txtBox_companyInfo.Hide();

            lbl_pros.Show();
            txtBox_pros.Hide();

            lbl_cons.Show();
            txtBox_cons.Hide();

            dynamic_lbl_companySite.Hide();
            dynamic_lbl_companyInfo.Hide();
            dynamic_lbl_companyProfileApp.Hide();

            btn_newCompany.Show();
            btn_edit.Show();
            btn_back.Hide();
            btn_save.Hide();

            btn_deactivateCurrentStatus.Hide();

            DeterminTextOrPicture();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            HidesSingleLineTextboxes();

            SavesDataToAFile();

            PopulateUi(Company1.FilePath);

        }

        private void SavesDataToAFile()
        {
            Company1.CompanyName = txtBox_companyName.Text;
            Company1.ApplicationDate = txtBox_applicationDate.Text;
            Company1.SourceSite = txtBox_sourceSite.Text;
            Company1.ApplicationStatus = txtBox_applicationStatus.Text;
            Company1.CompanySiteLink = txtBox_companySite.Text;
            Company1.CompanyProfileAppLink = txtBox_companyProfileApp.Text;
            Company1.CompanyInfoLink = txtBox_companyInfo.Text;
            Company1.Pros = txtBox_pros.Text;
            Company1.Cons = txtBox_cons.Text;

            string[] linesToBeSaved = new string[] {
                Company1.CompanyName,
                Company1.ApplicationDate,
                Company1.SourceSite,
                Company1.ApplicationStatus,
                Company1.CompanySiteLink,
                Company1.CompanyProfileAppLink,
                Company1.CompanyInfoLink,
                Company1.Pros,
                Company1.Cons,
                Company1.currentStatus ? "1" : "0",
                txtBox_jobDesc.Text };

            bool check = false;

            if (string.IsNullOrEmpty(Company1.FilePath))
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Company1.FilePath = Path.GetFullPath(saveFileDialog1.FileName);
                }

                string[] editedCompaniesArray = File.ReadAllLines("CompaniesList.txt");
                List<string> editedCompaniesList = new List<string>();
                editedCompaniesList.AddRange(editedCompaniesArray);
                editedCompaniesList.Add(Company1.CompanyName);
                editedCompaniesList.Add(Company1.FilePath);
                File.WriteAllLines("CompaniesList.txt", editedCompaniesList);

                check = true;
            }
            
            File.WriteAllLines(Company1.FilePath, linesToBeSaved);
            if (check)
            {
                ReloadRecentList();
            }
        }

        private void btn_newCompany_Click(object sender, EventArgs e)
        {
            Company1.FilePath = "";
            Company1.currentStatus = true;

            ReplaceLabelsWithTextboxes();

            #region Empties text boxes
            txtBox_companyName.Text = "";
            txtBox_applicationDate.Text = "";
            txtBox_applicationStatus.Text = "";
            txtBox_sourceSite.Text = "";
            txtBox_companySite.Text = "";
            txtBox_companyProfileApp.Text = "";
            txtBox_companyInfo.Text = "";
            txtBox_pros.Text = "";
            txtBox_cons.Text = "";
            txtBox_jobDesc.Text = ""; 
            #endregion

        }

        private void btn_deactivateCurrentStatus_Click(object sender, EventArgs e)
        {
            Company1.currentStatus = false;
            btn_deactivateCurrentStatus.Text = "done";
        }
    }
}
