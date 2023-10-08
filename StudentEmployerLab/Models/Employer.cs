using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudentEmployerLab.Models
{
    internal class Employer : User
    {
        public string StaffNumber { get; set; }
        public String Position;

        public Employer(string fname, string lastname, string staffNumber)
           : base(fname, lastname)
        {
            StaffNumber = staffNumber;
        }

        public override void ValidateUser()
        {
            //Calling base class validate method first
            base.ValidateUser();

            if (!IsValidStaffNumber(StaffNumber))
            {
                Console.WriteLine("Invalid staff number");
            }
            else
            { 
                Console.WriteLine("This confirms that staff number is confirmed.");
            }
            
        }

        private bool IsValidStaffNumber(string staffNumber)
        {
            return !string.IsNullOrEmpty(staffNumber) && Regex.IsMatch(staffNumber, @"^[AB]\d{7}$");
        }
    }
}
