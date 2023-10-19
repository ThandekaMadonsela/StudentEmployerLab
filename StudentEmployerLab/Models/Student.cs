using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StudentEmployerLab.Models
{
    internal class Student : User
    {

        private string StudentNumber;
        private string AverageMark;

        public Student(string fname, string lastname, string studentNumber)
            : base(fname, lastname)
        {
            SetStudentNumber(studentNumber);
        }

        //VALIDATE USER METHOD
        public override bool ValidateUser()
        {

            if (!base.ValidateUser() || !IsValidStudentNumber(StudentNumber))
            {
                Console.WriteLine("Student validation unsuccessful");
                return false;
            }
            
            
            //If valid
            Console.WriteLine("Student validation successful");
            return true;
        }

        //CONSUME POST
        public void ConsumePost(Post post)
        {
            Console.WriteLine($"Company name -> {post.GetCompanyName()}");
            Console.WriteLine($"Description -> {post.GetJobDescription()}");
            Console.WriteLine($"Department -> {post.GetDepartment()}");
            Console.WriteLine($"Rate -> {post.GetRate()}");
            Console.WriteLine($"Start date -> {post.GetStartDate()}");
            Console.WriteLine();
        }

        //SETTERS
        public bool SetStudentNumber(string value)
        {
            StudentNumber = value;
            return true;
        }
        public bool SetAverageMark(string value)
        {
            AverageMark = value;
            return true;
        }

        //GETTERS
        public string GetStudentNumber()
        {
            return StudentNumber;
        }

        public string GetAverageMark()
        {
            return AverageMark;
        }

        //VALIDATION METHOD
        private bool IsValidStudentNumber(string studentNumber)
        {
            if(string.IsNullOrEmpty(studentNumber) ||
               studentNumber.Length != 8 || !Regex.IsMatch(studentNumber, @"^\d{8}$"))
            {
                Console.WriteLine($"The student number {studentNumber} is invalid");
                return false;
            }

            //If valid
            return true;
        }

    }
}
