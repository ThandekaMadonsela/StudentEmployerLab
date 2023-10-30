using StudentEmployerLab.Interfaces;
using StudentEmployerLab.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DataList = StudentEmployerLab.Data.Data;

namespace StudentEmployerLab.Models
{
    internal class Employer : User
    {
        private string StaffNumber;
        private string Position;
        public List<IOpportunity> Opportunities { get; set; }


        public Employer(string fname, string lastname, List<Address> addresses, string staffNumber, List<IOpportunity> opportunities)
           : base(fname, lastname, addresses)
        {
                SetStaffNumber(staffNumber);
                Opportunities = opportunities;
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
       

        //CREATE POST
        public bool CreatePost(Post post)
        {
            Opportunities.Add(post);
            return true;
        }

        //CREATE BURSARY
        public bool CreateBursary(Bursary bursary)
        {
            Opportunities.Add(bursary);
            return true;
        }

        // CREATE PARTY
        public bool CreateParty(Party party)
        {
            Opportunities.Add(party);
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
