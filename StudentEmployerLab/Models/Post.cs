﻿using StudentEmployerLab.Interfaces;


namespace StudentEmployerLab.Models
{
    internal class Post : IOpportunity
    {
        private string CompanyName;
        private string OpportunityDescription;
        private string Department;
        private DateOnly StartDate;
        private decimal Rate;

        public Post(string companyName, string opportunityDescription, string department, DateOnly startDate, decimal rate)
        {
            CompanyName = companyName;
            OpportunityDescription = opportunityDescription;
            Department = department;
            StartDate = startDate;
            Rate = rate;
        }

        // SETTERS
        bool IOpportunity.SetCompanyName(string value)
        {
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

        //SetRate
        public bool SetRate(decimal value)
        {
            Rate = value;
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

        //GetRate
        public decimal GetRate()
        {
            return Rate;
        }

    }
}
