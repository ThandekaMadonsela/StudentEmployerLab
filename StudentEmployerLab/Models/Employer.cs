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
        public List<Post> Posts { get; set; }


        public Employer(string fname, string lastname, string staffNumber)
           : base(fname, lastname)
        {
            SetStaffNumber(staffNumber);
            Posts = new List<Post>();
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
        public void CreatePost()
        {
            var randomIndex = Util.Random.Next(20);

            Post post = new Post(DataList.CompanyNames[randomIndex], DataList.JobDescription[randomIndex],
                        DataList.Department[randomIndex], DataList.StartDates[randomIndex], DataList.Rates[randomIndex]);

            Posts.Add(post);
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
