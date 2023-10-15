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

            if (!base.ValidateUser())
                return false;

            if (!IsValidStudentNumber(StudentNumber))
                return false;
            
            //If valid
            Console.WriteLine("Student validation successful");
            return true;
        }

        //SETTERS
        public bool SetStudentNumber(string value)
        {
            if (!IsValidStudentNumber(value))
                return false;

            //If valid
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
