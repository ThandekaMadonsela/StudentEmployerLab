using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudentEmployerLab.Models
{
    internal class Student : User
    {

        public string StudentNumber { get; set; }
        public float AverageMark;

        public Student(string fname, string lastname, string studentNumber)
            : base(fname, lastname)
        {
            StudentNumber = studentNumber;
        }

        public override void ValidateUser()
        {
            //Calling base class validate method first
            base.ValidateUser();

            if (!IsValidStudentNumber(StudentNumber))
            {
                throw new ArgumentException("Invalid student number");
            }
            Console.WriteLine("This is a Student User.");
        }

        private bool IsValidStudentNumber(string studentNumber)
        {
            return !string.IsNullOrEmpty(studentNumber) && studentNumber.Length == 8 && Regex.IsMatch(studentNumber, @"^\d+$");
        }

    }
}
