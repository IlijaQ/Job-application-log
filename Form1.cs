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
            this.Text = "Job Application Log";
            
            ReloadRecentList();
            
            PopulateUi(companiesDictionary[(string)listbox_companies.Items[0]]);
            
            HidesSingleLineTextboxes();
            
        }

        Company Company1 = new Company();
        Dictionary<string, string> companiesDictionary = new Dictionary<string, string>();

        bool newCompanyForm = false;


        private void ReloadRecentList()
        {
            listbox_companies.Items.Clear();
            companiesDictionary.Clear();

            //creates initial list and company with dummy data on start. Granst User a first look how files are viewed before entering his own entries.
            if (!File.Exists("CompaniesList.txt"))
            {

                string[] starterList = new string[] { "TEST COMPANY", "TestCompany.txt" };

                string[] starterFile = new string[] {
                    "Test Company",
                    "133985592000000000",
                    "Service name",
                    "Pending",
                    "http://ilijac-001-site1.ftempurl.com/",
                    "https://github.com/IlijaQ",
                    "https://linkedin.com/in/ilija-kujovic-126352204",
                    "good company",
                    "no complaints",
                    "1",
                    "a fine job",
                    "c#",
                    "sql",
                    "ef",
                    "",
                    ">>>>>>> Click on \"New Company\" to get started."
                };

                File.WriteAllLines("CompaniesList.txt", starterList);
                File.WriteAllLines("TestCompany.txt", starterFile);

            }


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

        
        

        public void btn_edit_Click(object sender, EventArgs e)
        {


            ReplaceLabelsWithTextboxes();
            

            #region Populates TextBoxes with appropriate values
            txtBox_companyName.Text = Company1.CompanyName;

            numUpDwn_day.Value = Company1.ApplicationDate.Day;
            numUpDwn_month.Value = Company1.ApplicationDate.Month;
            numUpDwn_year.Value = Company1.ApplicationDate.Year;

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
            numUpDwn_day.Show();
            lbl_dayInMonth.Show();
            numUpDwn_month.Show();
            numUpDwn_year.Show();

            lbl_applicationStatus.Hide();
            txtBox_applicationStatus.Show();

            if (newCompanyForm)
            {
                btn_jobOffer.Hide();
                btn_deactivateCurrentStatus.Hide();
            }
            else if (Company1.currentStatus)
            {
                btn_jobOffer.Show();
                btn_deactivateCurrentStatus.Show();
                btn_deactivateCurrentStatus.Text = "deactivate";
            }
            

            lbl_sourceSite.Hide();
            picBox_sourceSite.Hide();
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

            txtBox_jobDesc.ReadOnly = false;
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

            if(companiesDictionary.Count == 0)
            {
                OpenNewCompanyForm();
            }
            else
            {
                #region Loading Data
                //ucitavanje infa sa lokalnog
                Company1.CompanyName = linesList[0];
                Company1.ApplicationDate = DateTime.FromFileTime(Convert.ToInt64(linesList[1]));
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
                else if (linesList[9] == "0")
                {
                    Company1.currentStatus = false;
                    lbl_companyName.ForeColor = Color.Gray;
                }

                Company1.JobDescription = linesList;
                Company1.JobDescription.RemoveRange(0, 10);

                lbl_companyName.Text = Company1.CompanyName;
                lbl_applicationDate.Text = Company1.ApplicationDate.ToString("dd.M.yyyy");
                lbl_sourceSite.Text = Company1.SourceSite;

                
                DetermineTextOrLabel();
                

                lbl_applicationStatus.Text = Company1.ApplicationStatus;

                #region adds hint to status label if one or more months has passed if status remains pending 
                if (Company1.currentStatus && lbl_applicationStatus.Text.ToLower().Contains("pending"))
                {
                    int currentTotalMonths = DateTime.Now.Month + DateTime.Now.Year * 12;
                    int applicationDateTotalMonths = Company1.ApplicationDate.Month + Company1.ApplicationDate.Year * 12;


                    if (currentTotalMonths == applicationDateTotalMonths + 1 && DateTime.Now.Day > Company1.ApplicationDate.Day)
                    {
                        lbl_applicationStatus.Text = Company1.ApplicationStatus + " (over a month)";
                    }

                    if (currentTotalMonths == applicationDateTotalMonths + 2)
                    {
                        lbl_applicationStatus.Text = DateTime.Now.Day > Company1.ApplicationDate.Day ? Company1.ApplicationStatus + " (over two months)" : Company1.ApplicationStatus + " (over a month)";

                    }
                    else if (currentTotalMonths == applicationDateTotalMonths + 3)
                    {
                        lbl_applicationStatus.Text = DateTime.Now.Day > Company1.ApplicationDate.Day ? Company1.ApplicationStatus + " (over three months, you shoud probably dactivate this one)" : Company1.ApplicationStatus + " (over two months)";

                    }
                    else if (currentTotalMonths > applicationDateTotalMonths + 3)
                        lbl_applicationStatus.Text = Company1.ApplicationStatus + " (over three months, you shoud probably dactivate this one)";
                }
                #endregion


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
        }

        private void DetermineTextOrLabel()
        {

            //loads apropriate label for source site instead of text, if one is provided
            if (Company1.SourceSite.ToLower() == "joberty" && File.Exists("JobertyLogo.png"))
            {
                picBox_sourceSite.Image = new Bitmap("JobertyLogo.png");
                lbl_sourceSite.Hide();
                picBox_sourceSite.Show();
            }
            else if (Company1.SourceSite.ToLower().Contains("helloworld") && File.Exists("HelloWorldLogo.png"))
            {
                picBox_sourceSite.Image = new Bitmap("HelloWorldLogo.png");
                lbl_sourceSite.Hide();
                picBox_sourceSite.Show();
            }
            else if (Company1.SourceSite.ToLower() == "infostud" && File.Exists("InfostudLogo.png"))
            {
                picBox_sourceSite.Image = new Bitmap("InfostudLogo.png");
                lbl_sourceSite.Hide();
                picBox_sourceSite.Show();
            }
            else if (Company1.SourceSite.ToLower() == "linkedin" && File.Exists("LinkedInLogo.png"))
            {
                picBox_sourceSite.Image = new Bitmap("LinkedInLogo.png");
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
            newCompanyForm = false;

        }

        private void HidesSingleLineTextboxes()//and replaces 'back' and 'save' with 'new' and 'edit' button
        {
            lbl_companyName.Show();
            txtBox_companyName.Hide();

            lbl_applicationDate.Show();
            numUpDwn_day.Hide();
            lbl_dayInMonth.Hide();
            numUpDwn_month.Hide();
            numUpDwn_year.Hide();
            

            lbl_applicationStatus.Show();
            txtBox_applicationStatus.Hide();

            DetermineTextOrLabel();
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
            btn_jobOffer.Hide();

            txtBox_jobDesc.ReadOnly = true;
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
            Company1.ApplicationDate = new DateTime((int)numUpDwn_year.Value, (int)numUpDwn_month.Value, (int)numUpDwn_day.Value); 
            Company1.SourceSite = txtBox_sourceSite.Text;
            Company1.ApplicationStatus = txtBox_applicationStatus.Text;
            Company1.CompanySiteLink = txtBox_companySite.Text;
            Company1.CompanyProfileAppLink = txtBox_companyProfileApp.Text;
            Company1.CompanyInfoLink = txtBox_companyInfo.Text;
            Company1.Pros = txtBox_pros.Text;
            Company1.Cons = txtBox_cons.Text;

            if (newCompanyForm)
                Company1.currentStatus = true;

            string[] linesToBeSaved = new string[] {
                Company1.CompanyName,
                Convert.ToString(Company1.ApplicationDate.ToFileTime()),
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

            //Actions if new Company is beeing created
            if (newCompanyForm)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog1.Title = "Save Company: Select storage location";

                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Company1.FilePath = Path.GetFullPath(saveFileDialog1.FileName);
                }

                //updating CompaniesList.txt
                string[] editedCompaniesArray = File.ReadAllLines("CompaniesList.txt");
                List<string> editedCompaniesList = new List<string>();
                editedCompaniesList.AddRange(editedCompaniesArray);
                editedCompaniesList.Add(Company1.CompanyName.ToUpper());//Uppercase name for Companiest with active status(default)
                editedCompaniesList.Add(Company1.FilePath);
                File.WriteAllLines("CompaniesList.txt", editedCompaniesList);

                check = true;
            }
            
            File.WriteAllLines(Company1.FilePath, linesToBeSaved);
            if (check)//in case a new Company is added to CompaniesList.txt
            {
                ReloadRecentList();
            }

            newCompanyForm = false;
        }

        private void btn_newCompany_Click(object sender, EventArgs e)
        {
            OpenNewCompanyForm();
        }

        private void OpenNewCompanyForm()
        {
            newCompanyForm = true;

            ReplaceLabelsWithTextboxes();

            #region Empties text boxes
            txtBox_companyName.Text = "";

            numUpDwn_day.Value = DateTime.Now.Day;
            numUpDwn_month.Value = DateTime.Now.Month;
            numUpDwn_year.Value = DateTime.Now.Year;

            txtBox_applicationStatus.Text = "Pending";
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
            
            //Companies with active status are written in uppercase in companies list
            //Deactivating Company status writes Company "normally" in the list.
            string[] editedCompaniesArray = File.ReadAllLines("CompaniesList.txt");
            editedCompaniesArray[Array.IndexOf(editedCompaniesArray, Company1.CompanyName.ToUpper())] = Company1.CompanyName;
            File.WriteAllLines("CompaniesList.txt", editedCompaniesArray);

            ReloadRecentList();
            btn_deactivateCurrentStatus.Text = "done";
        }

        #region Maximum day values depending on the month
        private void numUpDwn_month_ValueChanged(object sender, EventArgs e)
        {
            SetMaxDaysInMonth();
        }

        private void SetMaxDaysInMonth()
        {
            if (numUpDwn_month.Value == 4 || numUpDwn_month.Value == 6 || numUpDwn_month.Value == 9 || numUpDwn_month.Value == 11)
                numUpDwn_day.Maximum = 30;
            else if (numUpDwn_month.Value == 2)
            {
                if (DateTime.IsLeapYear((int)numUpDwn_year.Value))
                    numUpDwn_day.Maximum = 29;
                else
                    numUpDwn_day.Maximum = 28;
            }
            else
                numUpDwn_day.Maximum = 31;
        }

        private void numUpDwn_year_ValueChanged(object sender, EventArgs e)
        {
            SetMaxDaysInMonth();
        } 
        #endregion
    }
}
