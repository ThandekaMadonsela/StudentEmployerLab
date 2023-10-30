

using StudentEmployerLab.Interfaces;

namespace StudentEmployerLab.Models
{
    internal class Party : IOpportunity
    {
        private string PartyName;
        private string OpportunityDescription;
        private string Department;
        private DateOnly StartDate;
        private decimal EntranceFee;

        public Party(string partyName, string opportunityDescription, string department, DateOnly startDate, decimal entranceFee)
        {
            PartyName = partyName;
            OpportunityDescription = opportunityDescription;
            Department = department;
            StartDate = startDate;
            EntranceFee = entranceFee;
        }

        // SETTERS
        public bool SetCompanyName(string value)
        {
            PartyName = value;
            return true;
        }
        public bool SetOpportunityDescription(string value)
        {
            OpportunityDescription = value;
            return true;
        }
        public bool SetDepartment(string value)
        {
            Department = value;
            return true;
        }
        bool IOpportunity.SetStartDate(DateOnly value)
        {
            StartDate = value;
            return true;
        }

        //SetEntranceFee
        public bool SetEntranceFee(decimal value)
        {
            EntranceFee = value;
            return true;
        }

        //GETTERS
        string IOpportunity.GetCompanyName()
        {
            return PartyName;
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

        //GetEntranceFee
        public decimal GetEntranceFee()
        {
            return EntranceFee;
        }
    }
}
