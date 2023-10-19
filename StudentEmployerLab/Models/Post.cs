using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEmployerLab.Models
{
    internal class Post
    {
        private string CompanyName;
        private string JobDecription;
        private string Department;
        private DateOnly StartDate;
        private string Rate;

        public Post(string companyName, string jobDecription, string department, DateOnly startDate, string rate)
        {
            CompanyName = companyName;
            JobDecription = jobDecription;
            Department = department;
            StartDate = startDate;
            Rate = rate;
        }

        // SETTERS
        public void SetCompanyName(string value)
        {
            CompanyName = value;
        }
        public void SetJobDescription(string value)
        {
            JobDecription = value;
        }
        public void SetDepartment(string value)
        {
            JobDecription = value;
        }
        public void SetStartDate(DateOnly value)
        {
            StartDate = value;
        }
        public void SetRate(string value)
        {
            Rate = value;
        }

        //GETTERS
        public string GetCompanyName()
        {
            return CompanyName;
        }
        public string GetJobDescription()
        {
            return JobDecription;
        }
        public string GetDepartment()
        {
            return Department;
        }
        public DateOnly GetStartDate()
        {
            return StartDate;
        }
        public string GetRate()
        {
            return Rate;
        }
    }
}
