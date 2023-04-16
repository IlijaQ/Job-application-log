# Job-application-log
Keeping track of job applications and relevant info

Windows form .NET

Project main features:
- [x] Keeps all necessary information in one place (Company name, application date, application current status, job description, application website, basic feedback about the company - positive and negative).
- [x] Provides dedicated buttons that open a web browser to visit the company's official site and third-party informative sites for additional information about the company.
- [x] Saves all data about the company in a dedicated program directory in .xml format.
- [x] Provides a list of saved companies ordered by application date.
- [x] Selecting an entry from the list opens the stored data of the selected company and displays it in the app window.
- [x] Provides an option to save company information in a separate independent .txt file.

Screenshots and manual
![Preview](https://github.com/IlijaQ/Job-application-log/blob/main/Screenshots/Example.png)
On `edit` or `new company` , buttons are replaced with textboxes for URL to be pasted there, to map that button.
![Buttons](https://github.com/IlijaQ/Job-application-log/blob/main/Screenshots/Links.png)
Middle button `company profile app` since rearly used is not visible if no link is provided for it.

Program keeps track of application status. By clicking the `job offer` button, status is updated from "in progress" to "job offer".
![Job Offer](https://github.com/IlijaQ/Job-application-log/blob/main/Screenshots/JobOffer.png)
By clicking `Options/Save as separate .txt file` , dialog box appears, offering to save Company info in a separate .txt file.
![Save New Company](https://github.com/IlijaQ/Job-application-log/blob/main/Screenshots/Save.png)
![New Company](https://github.com/IlijaQ/Job-application-log/blob/main/Screenshots/NewCompany.png)
Companies that extended their job offer are labeled with green company name and with " > > " characters in Companies list.
![New Company](https://github.com/IlijaQ/Job-application-log/blob/main/Screenshots/StatusJobOffer.png)
Companies with application in progress are labeled with blue company name and with uppercase letters in Companies list.
![New Company](https://github.com/IlijaQ/Job-application-log/blob/main/Screenshots/StatusPending.png)
Companies that stopped application at some point are labeled with gray company name and just with lowerrcase letters in Companies list.
![New Company](https://github.com/IlijaQ/Job-application-log/blob/main/Screenshots/StatusStopped.png)
