using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplicationLog
{
    public class Company
    {
        public string CompanyName { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string SourceSite { get; set; }
        public string ApplicationStatus { get; set; }
        public string CompanySiteLink { get; set; }
        public string CompanyInfoLink { get; set; }
        public string CompanyProfileAppLink { get; set; }
        public string Pros { get; set; }
        public string Cons { get; set; }
        public List<string> JobDesccription { get; set; }

        public Company()
        {

        }
    }
}
