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
using System.Xml;
using System.Xml.Serialization;

namespace JobApplicationLog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Job Application Log";

            Directory.CreateDirectory(@".\..\..\Companies");

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
            
            if (!File.Exists("CompaniesList.xml"))
            {
                CreateInitialFiles();
            }

            XmlDocument companiesListXml = new XmlDocument();
            companiesListXml.Load("CompaniesList.xml");
            XmlNodeList companyNodes = companiesListXml.GetElementsByTagName("company");

            List<string> companiesList = new List<string>();
            companiesList.Capacity = companyNodes.Count;

            foreach (XmlNode company in companyNodes)
            {
                XmlNode nameNode = company.SelectSingleNode("name");
                XmlNode pathNode = company.SelectSingleNode("path");

                companiesDictionary.Add(nameNode.InnerText, pathNode.InnerText);
                companiesList.Add(nameNode.InnerText);
            }
            
            companiesList.Reverse();
            listbox_companies.Items.AddRange(companiesList.ToArray());
        }

        // creates initial list and company with dummy data on start. Granst User a first look how files are viewed before entering his own entries.
        private void CreateInitialFiles()
        {
            #region adding dummy data for initial company file
            Company1.CompanyName = "Test Company";
            Company1.ApplicationDate = DateTime.Now;
            Company1.SourceSite = "NSZ";
            Company1.ApplicationStatus = "no applications yet";
            Company1.CompanySiteLink = "https://github.com/IlijaQ";
            Company1.CompanyProfileAppLink = "https://linkedin.com/in/ilija-kujovic-126352204";
            Company1.CompanyInfoLink = "https://github.com/IlijaQ/Job-application-log";
            Company1.Pros = "good company";
            Company1.Cons = "no complaints";
            Company1.CurrentStatus = (int)Status.InProgress;

            Company1.JobDescription = new List<string>();
            Company1.JobDescription.Add("[EXAMPLE]");
            Company1.JobDescription.Add("You are a good candidate if you can check at least two of the following key skills:");
            Company1.JobDescription.Add("-knowledge of C# and .NET framework.");
            Company1.JobDescription.Add("-knowledge of HTML, CSS");
            Company1.JobDescription.Add("-knowledge of SQL and experience in working with databases");
            Company1.JobDescription.Add("-Experience with ASP.NET MVC and/or Razor Pages");
            Company1.JobDescription.Add("-Experience in working with Entity Framework (or other persistence frameworks)");
            Company1.JobDescription.Add("");
            Company1.JobDescription.Add("Click on \"New Company\" to get started.");
            Company1.JobDescription.Add("Click on Help / About to open manual.");
            Company1.JobDescription.Add("Click on \"Company info\" on this entry to view program features with screenshots, and manual."); 
            #endregion

            // creates initial company file
            XmlSerializer CompanyXmlSerializer = new XmlSerializer(typeof(Company));
            using (FileStream CompanyFileStream = File.Create("TestCompany.xml"))
            {
                CompanyXmlSerializer.Serialize(CompanyFileStream, Company1);
            }

            // Creates CompaniesList.xml and ads initial file to the list
            XmlDocument starterList = new XmlDocument();
            XmlElement root = starterList.CreateElement("CompaniesList");
            starterList.AppendChild(root);
            
            XmlElement company = starterList.CreateElement("company");
            XmlElement name = starterList.CreateElement("name");
            XmlElement path = starterList.CreateElement("path");
            root.AppendChild(company);
            company.AppendChild(name);
            company.AppendChild(path);

            name.InnerText = "GET STARTED";
            path.InnerText = "TestCompany.xml";

            starterList.Save("CompaniesList.xml");
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

            PopulateUi(companiesDictionary[(string)listbox_companies.SelectedItem]);
        }

        private void PopulateUi(string selectedFile)
        {
            Company1.FilePath = selectedFile;

            XmlSerializer CompanyXmlDeSerializer = new XmlSerializer(typeof(Company));
            using (FileStream CompanyFileStream = new FileStream(Company1.FilePath, FileMode.Open))
            {
                Company1 = (Company)CompanyXmlDeSerializer.Deserialize(CompanyFileStream);
            }

            if(companiesDictionary.Count == 0)
            {
                OpenNewCompanyForm();
            }

            #region Loading Data

            // setting labels
            switch (Company1.CurrentStatus)
            {
                case (int)Status.JobOffer:
                    lbl_companyName.ForeColor = Color.FromArgb(122, 209, 19); // green
                    break;
                case (int)Status.InProgress:
                    lbl_companyName.ForeColor = Color.FromArgb(51, 153, 255); // vibrant blue
                    break;
                case (int)Status.Rejected:
                    lbl_companyName.ForeColor = Color.Gray;
                    break;
            }

            lbl_companyName.Text = Company1.CompanyName;
            lbl_applicationDate.Text = Company1.ApplicationDate.ToString("dd.M.yyyy");
            lbl_applicationStatus.Text = Company1.ApplicationStatus;
            lbl_sourceSite.Text = Company1.SourceSite;
            DetermineTextOrLabel();

            #region adds hint to status label if one or more months has passed if status remains pending 
            if (Company1.CurrentStatus == (int)Status.InProgress && lbl_applicationStatus.Text.ToLower().Contains("pending"))
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
                btn_companyProfileApp.Hide();
            else
                btn_companyProfileApp.Show();

            lbl_pros.Text = Company1.Pros;
            lbl_cons.Text = Company1.Cons;

            PopulatesJobDesc();
            #endregion
        }

        private void DetermineTextOrLabel()
        {
            // loads apropriate label for source site instead of text, if one is provided
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

            for (int i = 0; i < Company1.JobDescription.Count; i++) // adds new line in last textbox for every item from position 4 to the end of the array
            {
                txtBox_jobDesc.Text = txtBox_jobDesc.Text + Company1.JobDescription[i];
                if (i < Company1.JobDescription.Count - 1) // prevents adding an empty line at the end of textbox content
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

            Company1.JobDescription = new List<string>();
            Company1.JobDescription.AddRange(txtBox_jobDesc.Lines);

            if (newCompanyForm)
                Company1.CurrentStatus = (int)Status.InProgress;

            // Actions if new Company is beeing created
            if (newCompanyForm)
            {
                Company1.FilePath = @".\..\..\Companies\xmlFiles\" + Company1.CompanyName.Replace(" ", "") + ".xml";

                // updating CompaniesList.xml
                XmlDocument companiesListXml = new XmlDocument();
                companiesListXml.Load("CompaniesList.xml");

                XmlElement root = companiesListXml.DocumentElement;
                XmlElement company = companiesListXml.CreateElement("company");
                XmlElement name = companiesListXml.CreateElement("name");
                XmlElement path = companiesListXml.CreateElement("path");

                name.InnerText = Company1.CompanyName.ToUpper(); // Uppercase name for Companiest with active status(default)
                path.InnerText = Company1.FilePath;

                company.AppendChild(name);
                company.AppendChild(path);
                root.AppendChild(company);

                companiesListXml.Save("CompaniesList.xml");

                ReloadRecentList();
            }

            // cheks if Comapany name is changed to update CompaniesList.xml
            if (IfCoNameChangedIndicator != Company1.CompanyName && !newCompanyForm)
            {
                XmlDocument companiesListXml = new XmlDocument();
                companiesListXml.Load("CompaniesList.xml");
                XmlNode nameNode;

                switch (Company1.CurrentStatus)
                {
                    // applies the change according to how company is displayed on the list (depneding on CurrentStatus)
                    case (int)Status.Rejected:
                        nameNode = companiesListXml.SelectSingleNode($"//name[Text()='{IfCoNameChangedIndicator}']");
                        nameNode.InnerText = Company1.CompanyName;
                        break;
                    case (int)Status.InProgress:
                        nameNode = companiesListXml.SelectSingleNode($"//name[Text()='{IfCoNameChangedIndicator.ToUpper()}']");
                        nameNode.InnerText = Company1.CompanyName.ToUpper();
                        break;
                    case (int)Status.JobOffer:
                        nameNode = companiesListXml.SelectSingleNode($"//name[Text()=' > > {IfCoNameChangedIndicator}']");
                        nameNode.InnerText = $" > > {Company1.CompanyName}";
                        break;
                }
                companiesListXml.Save("CompaniesList.xml");

                ReloadRecentList();
            }

            XmlSerializer CompanyXmlSerializer = new XmlSerializer(typeof(Company));
            using (FileStream CompanyFileStream = File.Create(Company1.FilePath))
            {
                CompanyXmlSerializer.Serialize(CompanyFileStream, Company1);
            }

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
            Company1.CurrentStatus = (int)Status.Rejected;
            SavesDataToAFile();

            // Companies with active status are written in uppercase in companies list
            // Deactivating Company status writes Company "normally" in the list.
            XmlDocument companiesListXml = new XmlDocument();
            companiesListXml.Load("CompaniesList.xml");
            XmlNode nameNode = companiesListXml.SelectSingleNode($"//name[text()='{Company1.CompanyName.ToUpper()}']");
            nameNode.InnerText = Company1.CompanyName;
            companiesListXml.Save("CompaniesList.xml");

            ReloadRecentList();
            PopulateUi(Company1.FilePath);
            HidesSingleLineTextboxes();
            
            MessageBox.Show($"Company: {Company1.CompanyName}\r\nJob aplication status: not active");
        }

        private void btn_jobOffer_Click(object sender, EventArgs e)
        {
            Company1.CurrentStatus = (int)Status.JobOffer;
            txtBox_applicationStatus.Text = "Job Offer"; // compatability with SavesDataToAFile() method
            
            SavesDataToAFile();

            //hints out the Company that offered a Job Offer in companies list
            XmlDocument companiesListXml = new XmlDocument();
            companiesListXml.Load("CompaniesList.xml");
            XmlNode nameNode = companiesListXml.SelectSingleNode($"//name[text()='{Company1.CompanyName.ToUpper()}']");
            nameNode.InnerText = $" > > {Company1.CompanyName}";
            companiesListXml.Save("CompaniesList.xml");

            ReloadRecentList();
            PopulateUi(Company1.FilePath);
            HidesSingleLineTextboxes();

            MessageBox.Show(String.Format("{0, 11}{1, 9}\n\n{2, 12}{3, 7}\n\n{4}", "SUBJECT:", "FREEMAN", "STATUS:", "HIRED", "AWAITING ASSIGNMENT"));
        }

        private void btn_restoreStatus_Click(object sender, EventArgs e)
        {
            XmlDocument companiesListXml = new XmlDocument();
            companiesListXml.Load("CompaniesList.xml");
            XmlNode nameNode;

            switch (Company1.CurrentStatus)
            {
                case (int)Status.Rejected: //      /CompaniesList/company/name
                    nameNode = companiesListXml.SelectSingleNode($"//name[text()='{Company1.CompanyName}']");
                    nameNode.InnerText = Company1.CompanyName.ToUpper();
                    break;
                case (int)Status.JobOffer:
                    nameNode = companiesListXml.SelectSingleNode($"//name[text()=' > > {Company1.CompanyName}']");
                    nameNode.InnerText = Company1.CompanyName.ToUpper();
                    break;
            }
            companiesListXml.Save("CompaniesList.xml");

            Company1.CurrentStatus = (int)Status.InProgress;
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

        private void ReplaceLabelsWithTextboxes() // and replaces 'new company' and 'edit' buttons with 'back' and 'save'
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

            if (Company1.CurrentStatus == (int)Status.Rejected || newCompanyForm || Company1.CurrentStatus == (int)Status.JobOffer)
            {
                btn_jobOffer.Hide();
                btn_deactivateCurrentStatus.Hide();
                if(!newCompanyForm)
                    btn_restoreStatus.Show();
            }
            else if (Company1.CurrentStatus == (int)Status.InProgress)
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

        private void saveInAditionaltxtFileToolStripMenuItem_Click(object sender, EventArgs e)
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
                case (int)Status.Rejected: stat = "REJECTED"; break;
                case (int)Status.InProgress: stat = "IN PROGRESS"; break;
                case (int)Status.JobOffer: stat = "JOB OFFER"; break;
            }

            string coProfile = String.Format("{0, -25}{1}", "COMPANY PROFILE APP:", Company1.CompanyProfileAppLink);
            string coReviews = String.Format("{0, -25}{1}", "COMPANY REVIEWS FORUM:", Company1.CompanyInfoLink);

            string[] linesToBeSaved = new string[] {
                String.Format("{0, -25}{1}", "COMPANY NAME:", Company1.CompanyName),
                String.Format("{0, -25}{1}", "APPLICATION DATE:", Company1.ApplicationDate.ToString("dd-M-yyyy")),
                String.Format("{0, -25}{1} {2}", "APPLICATION STATUS:", stat, Company1.ApplicationStatus),
                String.Format("{0, -25}{1}", "SOURCE SITE:", Company1.SourceSite),
                "",
                String.Format("{0, -25}{1}", "COMPANY SITE LINK:", Company1.CompanySiteLink),
                String.IsNullOrEmpty(Company1.CompanyProfileAppLink) ? coReviews : $"{coProfile}\r\n{coReviews}", //eliminates entire row COMPANY PROFILE APP if one doesn' exist, usually it doesn't
                "",
                String.Format("{0, -25}{1}", "PROS:", Company1.Pros),
                String.Format("{0, -25}{1}", "CONS:", Company1.Cons),
                "",
                "",
                $"JOB DESCRIPTION:",
                "",
                txtBox_jobDesc.Text
            };

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

        enum Status
        {
            Rejected,
            InProgress,
            JobOffer
        }
    }
}
