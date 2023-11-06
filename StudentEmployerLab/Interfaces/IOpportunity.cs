
namespace StudentEmployerLab.Interfaces
{
    internal interface IOpportunity
    {
        //SETTERS
        bool SetCompanyName(string value);
        bool SetOpportunityDescription(string value);
        bool SetDepartment(string value);
        bool SetStartDate(DateOnly value);

        //GETTERS
        string GetCompanyName();
        string GetOpportunityDescription();
        string GetDepartment();
        DateOnly GetStartDate();

        //string CompanyNames { get; set; }
        //string OpportunityDescription { get; set; }
        //string Department { get; set; }
        //DateOnly StartDate { get; set; }
    }
}
