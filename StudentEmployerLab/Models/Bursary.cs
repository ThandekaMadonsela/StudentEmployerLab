using StudentEmployerLab.Interfaces;

namespace StudentEmployerLab.Models
{
    internal class Bursary : IOpportunity
    {
        private string CompanyName;
        private string OpportunityDescription;
        private string Department;
        private DateOnly StartDate;
        private decimal BursaryValue;

        public Bursary(string companyName, string opportunityDescription, string department, DateOnly startDate, decimal bursaryValue)
        {
            CompanyName = companyName;
            OpportunityDescription = opportunityDescription;
            Department = department;
            StartDate = startDate;
            BursaryValue = bursaryValue;
        }

        // SETTERS
        public bool SetCompanyName(string value)
        {
            //I will do some validation later
            CompanyName = value;
            return true;
        }
        public bool SetOpportunityDescription(string value)
        {
            OpportunityDescription = value;
            return true;
        }
        bool IOpportunity.SetDepartment(string value)
        {
            Department = value;
            return true;
        }
        bool IOpportunity.SetStartDate(DateOnly value)
        {
            StartDate = value;
            return true;
        }

        //SetBursaryValue
        public bool SetBursaryValue(decimal value)
        {
            BursaryValue = value;
            return true;
        }

        //GETTERS
        string IOpportunity.GetCompanyName()
        {
            return CompanyName;
        }

        string IOpportunity.GetOpportunityDescription()
        {
            return OpportunityDescription;
        }

        string IOpportunity.GetDepartment()
        {
            return Department;
        }

        DateOnly IOpportunity.GetStartDate()
        {
            return StartDate;
        }

        //GetBursaryValue
        public decimal GetBursaryValue()
        {
            return BursaryValue;
        }
    }
}
