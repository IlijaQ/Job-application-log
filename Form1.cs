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
using System.Drawing.Printing;

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

                string[] starterList = new string[] { "GET STARTED", "TestCompany.txt" };

                string[] starterFile = new string[] {
                    "Test Company",
                    "133985592000000000",
                    "Service name",
                    "Pending",
                    "https://linkedin.com/in/ilija-kujovic-126352204",
                    "https://github.com/IlijaQ",
                    "https://github.com/IlijaQ/Job-application-log",
                    "good company",
                    "no complaints",
                    "1",
                    "[EXAMPLE]",
                    "You are a good candidate if you can check at least two of the following key skills:",
                    "-knowledge of C# and .NET framework.",
                    "-knowledge of HTML, CSS",
                    "-knowledge of SQL and experience in working with databases",
                    "-Experience with ASP.NET MVC and/or Razor Pages",
                    "-Experience in working with Entity Framework (or other persistence frameworks)",
                    "",
                    "",
                    "///////////////  Click on \"New Company\" to get started.",
                    "///////////////  Click on \"Company info\" on this entry to view program features and manual."
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
        
        private void listbox_companies_DoubleClick(object sender, EventArgs e)
        {
            if (txtBox_companyName.Visible)
                HidesSingleLineTextboxes();

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

                switch(linesList[9])
                {
                    case "2":   //Company offered a Job Offer
                        Company1.CurrentStatus = 2;
                        lbl_companyName.ForeColor = Color.FromArgb(122, 209, 19);//green
                        break;
                    case "1":   //Application in motion
                        Company1.CurrentStatus = 1;
                        lbl_companyName.ForeColor = Color.FromArgb(51, 153, 255);//vibrant blue
                        break;
                    case "0":   //Aplication not active
                        Company1.CurrentStatus = 0;
                        lbl_companyName.ForeColor = Color.Gray;
                        break;
                }


                Company1.JobDescription = linesList;
                Company1.JobDescription.RemoveRange(0, 10);

                lbl_companyName.Text = Company1.CompanyName;
                lbl_applicationDate.Text = Company1.ApplicationDate.ToString("dd.M.yyyy");
                lbl_sourceSite.Text = Company1.SourceSite;

                
                DetermineTextOrLabel();
                

                lbl_applicationStatus.Text = Company1.ApplicationStatus;

                #region adds hint to status label if one or more months has passed if status remains pending 
                if (Company1.CurrentStatus == 1 && lbl_applicationStatus.Text.ToLower().Contains("pending"))
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
            string pathToLogoDir = @".\..\..\additional\logo\";
            if (Company1.SourceSite.ToLower() == "joberty" && File.Exists($"{pathToLogoDir}JobertyLogo.png"))
            {
                picBox_sourceSite.Image = new Bitmap($"{pathToLogoDir}JobertyLogo.png");
                lbl_sourceSite.Hide();
                picBox_sourceSite.Show();
            }
            else if (Company1.SourceSite.ToLower().Contains("helloworld") && File.Exists($"{pathToLogoDir}HelloWorldLogo.png"))
            {
                picBox_sourceSite.Image = new Bitmap($"{pathToLogoDir}HelloWorldLogo.png");
                lbl_sourceSite.Hide();
                picBox_sourceSite.Show();
            }
            else if (Company1.SourceSite.ToLower() == "infostud" && File.Exists($"{pathToLogoDir}InfostudLogo.png"))
            {
                picBox_sourceSite.Image = new Bitmap($"{pathToLogoDir}InfostudLogo.png");
                lbl_sourceSite.Hide();
                picBox_sourceSite.Show();
            }
            else if (Company1.SourceSite.ToLower() == "linkedin" && File.Exists($"{pathToLogoDir}LinkedInLogo.png"))
            {
                picBox_sourceSite.Image = new Bitmap($"{pathToLogoDir}LinkedInLogo.png");
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            HidesSingleLineTextboxes();

            SavesDataToAFile();

            PopulateUi(Company1.FilePath);

        }

        private void SavesDataToAFile()
        {
            string IfCoNameChangedIndicator = Company1.CompanyName;
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
                Company1.CurrentStatus = 1;

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
                Convert.ToString(Company1.CurrentStatus),
                txtBox_jobDesc.Text };


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

                ReloadRecentList();
            }

            //cheks if Comapany name is changed to update CompaniesList.txt
            if (IfCoNameChangedIndicator != Company1.CompanyName && !newCompanyForm)
            {
                string[] editedCompaniesArray = File.ReadAllLines("CompaniesList.txt");

                switch (Company1.CurrentStatus)
                {
                    //applies the change according to how company is displayed on the list (depneding on CurrentStatus)
                    case 0: editedCompaniesArray[Array.IndexOf(editedCompaniesArray, IfCoNameChangedIndicator)] = Company1.CompanyName; break;
                    case 1: editedCompaniesArray[Array.IndexOf(editedCompaniesArray, IfCoNameChangedIndicator.ToUpper())] = Company1.CompanyName.ToUpper(); break;
                    case 2: editedCompaniesArray[Array.IndexOf(editedCompaniesArray, ($" > > {IfCoNameChangedIndicator}"))] = $" > > {Company1.CompanyName}"; break;
                }

                File.WriteAllLines("CompaniesList.txt", editedCompaniesArray);

                ReloadRecentList();
            }

            File.WriteAllLines(Company1.FilePath, linesToBeSaved);

            newCompanyForm = false;
        }

        private void newCompanyToolStripMenuItem_Click(object sender, EventArgs e)
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
            Company1.CurrentStatus = 0;
            SavesDataToAFile();

            //Companies with active status are written in uppercase in companies list
            //Deactivating Company status writes Company "normally" in the list.
            string[] editedCompaniesArray = File.ReadAllLines("CompaniesList.txt");
            editedCompaniesArray[Array.IndexOf(editedCompaniesArray, Company1.CompanyName.ToUpper())] = Company1.CompanyName;
            File.WriteAllLines("CompaniesList.txt", editedCompaniesArray);

            ReloadRecentList();

            PopulateUi(Company1.FilePath);

            HidesSingleLineTextboxes();

            
            MessageBox.Show($"Company: {Company1.CompanyName}\r\nJob aplication status: not active");
        }

        private void btn_jobOffer_Click(object sender, EventArgs e)
        {
            Company1.CurrentStatus = 2;
            txtBox_applicationStatus.Text = "Job Offer";//compatability with SavesDataToAFile() method
            
            SavesDataToAFile();

            //hints out the Company that offered a Job Offer in companies list
            string[] editedCompaniesArray = File.ReadAllLines("CompaniesList.txt");
            editedCompaniesArray[Array.IndexOf(editedCompaniesArray, Company1.CompanyName.ToUpper())] = $" > > {Company1.CompanyName}";
            File.WriteAllLines("CompaniesList.txt", editedCompaniesArray);

            ReloadRecentList();

            PopulateUi(Company1.FilePath);
            
            HidesSingleLineTextboxes();


            MessageBox.Show(String.Format("{0, 11}{1, 9}\n\n{2, 12}{3, 7}\n\n{4}", "SUBJECT:", "FREEMAN", "STATUS:", "HIRED", "AWAITING ASSIGNMENT"));

        }

        private void btn_restoreStatus_Click(object sender, EventArgs e)
        {
            string[] editedCompaniesArray = File.ReadAllLines("CompaniesList.txt");
            switch (Company1.CurrentStatus)
            {
                case 0:
                    editedCompaniesArray[Array.IndexOf(editedCompaniesArray, Company1.CompanyName)] = Company1.CompanyName.ToUpper();
                    break;
                case 2:
                    editedCompaniesArray[Array.IndexOf(editedCompaniesArray, $" > > {Company1.CompanyName}")] = Company1.CompanyName.ToUpper();
                    break;
            }
            File.WriteAllLines("CompaniesList.txt", editedCompaniesArray);

            Company1.CurrentStatus = 1;
            SavesDataToAFile();
            

            ReloadRecentList();

            PopulateUi(Company1.FilePath);

            HidesSingleLineTextboxes();


            MessageBox.Show($"Company: {Company1.CompanyName}\r\nJob aplication status: default");
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


        private void ReplaceLabelsWithTextboxes()//and replaces 'new company' and 'edit' buttons with 'back' and 'save'
        {
            btn_edit.Hide();
            btn_back.Show();
            btn_save.Show();


            lbl_companyName.Hide();
            txtBox_companyName.Show();

            lbl_applicationDate.Hide();
            numUpDwn_day.Show();
            lbl_dayInMonth.Show();
            numUpDwn_month.Show();
            numUpDwn_year.Show();

            lbl_sourceSite.Hide();
            picBox_sourceSite.Hide();
            txtBox_sourceSite.Show();

            lbl_applicationStatus.Hide();
            txtBox_applicationStatus.Show();

            if (Company1.CurrentStatus == 0 || newCompanyForm || Company1.CurrentStatus == 2)
            {
                btn_jobOffer.Hide();
                btn_deactivateCurrentStatus.Hide();
                btn_restoreStatus.Show();
            }
            else if (Company1.CurrentStatus == 1)
            {
                btn_jobOffer.Show();
                btn_deactivateCurrentStatus.Show();
                btn_restoreStatus.Hide();
            }


            groupBox_companySite.Show();
            groupBox_companyProfileApp.Show();
            groupBox_companyInfo.Show();

            btn_companySite.Hide();
            btn_companyProfileApp.Hide();
            btn_companyInfo.Hide();


            lbl_pros.Hide();
            txtBox_pros.Show();

            lbl_cons.Hide();
            txtBox_cons.Show();


            txtBox_jobDesc.ReadOnly = false;
        }

        
        private void HidesSingleLineTextboxes()//and replaces 'back' and 'save' with 'new' and 'edit' button
        {
            btn_edit.Show();
            btn_back.Hide();
            btn_save.Hide();


            lbl_companyName.Show();
            txtBox_companyName.Hide();

            lbl_applicationDate.Show();
            numUpDwn_day.Hide();
            lbl_dayInMonth.Hide();
            numUpDwn_month.Hide();
            numUpDwn_year.Hide();

            DetermineTextOrLabel();
            txtBox_sourceSite.Hide();

            lbl_applicationStatus.Show();
            txtBox_applicationStatus.Hide();

            btn_deactivateCurrentStatus.Hide();
            btn_jobOffer.Hide();
            btn_restoreStatus.Hide();


            groupBox_companySite.Hide();
            groupBox_companyProfileApp.Hide();
            groupBox_companyInfo.Hide();

            btn_companySite.Show();
            if (!string.IsNullOrEmpty(Company1.CompanyProfileAppLink))
            {
                btn_companyProfileApp.Show();
            }
            btn_companyInfo.Show();


            lbl_pros.Show();
            txtBox_pros.Hide();

            lbl_cons.Show();
            txtBox_cons.Hide();
            

            txtBox_jobDesc.ReadOnly = true;
        }

        private void txtBox_companyInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_companyProfileApp_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saveInAAditionaltxtFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "Save Company in a separate text file";

            string txtFilePath = "";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFilePath = Path.GetFullPath(saveFileDialog1.FileName);
            }

            string stat = "";
            switch (Company1.CurrentStatus) {
                case 0: stat = "REJECTED"; break;
                case 1: stat = "IN PROGRESS"; break;
                case 2: stat = "JOB OFFER"; break;
            }

            string coProfile = String.Format("{0, -25}{1}", "COMPANY PROFILE APP:", Company1.CompanyProfileAppLink);
            string coReviews = String.Format("{0, -25}{1}", "COMPANY REVIEWS FORUM:", Company1.CompanyInfoLink);

            string[] linesToBeSaved = new string[] {
                String.Format("{0, -25}{1}", "COMPANY NAME:", Company1.CompanyName),
                String.Format("{0, -25}{1}", "APPLICATION DATE:", Company1.ApplicationDate.ToString("dd-M-yyyy")),
                String.Format("{0, -25}{1} {2}", "APPLICATION STATUS:", stat, Company1.ApplicationStatus),
                String.Format("{0, -25}{1}", "SOURCE SITE:", Company1.SourceSite),
                "",
                String.Format("{0, -25}{1}", "CONPANY SITE LINK:", Company1.CompanySiteLink),
                String.IsNullOrEmpty(Company1.CompanyProfileAppLink) ? coReviews : $"{coProfile}\r\n{coReviews}", //eliminates entire row COMPANY PROFILE APP if one doesn' exist, usually it doesn't
                "",
                String.Format("{0, -25}{1}", "PROS:", Company1.Pros),
                String.Format("{0, -25}{1}", "CONS:", Company1.Cons),
                "",
                "",
                $"JOB DESCRIPTION:",
                "",
                txtBox_jobDesc.Text };

            if(!String.IsNullOrEmpty(txtFilePath))
                File.WriteAllLines(txtFilePath, linesToBeSaved);

            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@".\..\..\additional\About.txt");
        }

        private void developerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/IlijaQ");
        }

        private void sourceCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/IlijaQ/Job-application-log");
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming soon");
        }
    }
}
