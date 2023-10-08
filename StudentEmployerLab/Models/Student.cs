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
            
            base.ValidateUser();

            if (!IsValidStudentNumber(StudentNumber))
            {
                Console.WriteLine("Invalid student number");
            }
            else
            {
                Console.WriteLine("This confirms that student number is confirmed.");
            }
           
        }

        private bool IsValidStudentNumber(string studentNumber)
        {
            return !string.IsNullOrEmpty(studentNumber) && studentNumber.Length == 8 && Regex.IsMatch(studentNumber, @"^\d{8}$");
        }

    }
}
