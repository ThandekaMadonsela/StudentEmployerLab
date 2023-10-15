using StudentEmployerLab.Interfaces;
using StudentEmployerLab.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudentEmployerLab.Models
{
    internal class Employer : User,IEmployer
    {
        private readonly IPostService _postService;
        private string StaffNumber;
        private string Position;
        public List<Post> Posts { get; set; }

        public Employer(string fname, string lastname, string staffNumber)
           : base(fname, lastname)
        {
            SetStaffNumber(staffNumber);
            _postService = new PostService();
        }

        //VALIDATE USER METHOD
        public override bool ValidateUser()
        {
            if(!base.ValidateUser())
               return false;

            if (!IsValidStaffNumber(StaffNumber))
                return false;
           
            //If valid
            Console.WriteLine("Employer validation successful");
            return true;
            
        }

        //CREATE POST
        public Post CreatePost()
        {
            Post post = _postService.CreatePost(this);
            return post;
        }

        //SETTERS
        public bool SetStaffNumber(string value)
        {
            if (!IsValidStaffNumber(value))
                return false;

            //If valid
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
            if(!string.IsNullOrEmpty(staffNumber) && Regex.IsMatch(staffNumber, @"^[AB]\d{7}$"))
            {
                Console.WriteLine("Invalid stuff number");
                return false;
            }

            //If valid
            return true;
        }
    }
}
