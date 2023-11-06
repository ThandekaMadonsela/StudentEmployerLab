using StudentEmployerLab.Interfaces;
using System.Text.RegularExpressions;

namespace StudentEmployerLab.Models
{
    internal class Employer : User
    {
        private string StaffNumber;
        private string Position;
        private List<IOpportunity> _opportunities { get; set; }


        public Employer(string fname, string lastname, string staffNumber)
           : base(fname, lastname)
        {
                SetStaffNumber(staffNumber);
               _opportunities = new List<IOpportunity>();
        }

        //VALIDATE USER METHOD
        public override bool ValidateUser()
        {
            if(!base.ValidateUser() || !IsValidStaffNumber(StaffNumber))
            {
                Console.WriteLine("Employer validation unsuccessful");
                return false;
            }
           
            //If valid
            Console.WriteLine("Employer validation successful");
            return true;
            
        }
       

        //CREATE OPPORTUNITY
        public bool CreateOpportunity(IOpportunity opportunity)
        {
            _opportunities.Add(opportunity);
            return true;
        }

        //SETTERS
        public bool SetStaffNumber(string value)
        {
            
            StaffNumber = value;
            return true;
        }
        public bool SetPosition(string value)
        {
            Position = value;
            return true;
        }

        //GETTERS
        public string GetStaffNumber()
        {
            return StaffNumber;
        }

        public string GetPosition()
        {
            return Position;
        }

        public IEnumerable<IOpportunity> GetOpportunities()
        {
            return _opportunities;
        }

        //VALIDATION METHOD
        private bool IsValidStaffNumber(string staffNumber)
        {
            if(string.IsNullOrEmpty(staffNumber) || !Regex.IsMatch(staffNumber, @"^[AB]\d{7}$"))
            {
                Console.WriteLine($"The staff number {staffNumber} invalid");
                return false;
            }

            //If valid
            return true;
        }
    }
}
