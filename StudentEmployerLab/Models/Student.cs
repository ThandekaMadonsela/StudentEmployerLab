using System.Text.RegularExpressions;
using StudentEmployerLab.Interfaces;

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
        public void ConsumePost(IOpportunity opportunity)
        {
            string fname, lname;
            
            if (GetFullName(out fname, out lname))
                Console.WriteLine($"Student Names: {fname} {lname}");

            Console.WriteLine($"Company name -> {opportunity.GetCompanyName()}");
            Console.WriteLine($"Description -> {opportunity.GetOpportunityDescription()}");
            Console.WriteLine($"Department -> {opportunity.GetDepartment()}");
            Console.WriteLine($"Start date -> {opportunity.GetStartDate()}");


            if (opportunity is Post post)
                Console.WriteLine($"Rate -> R{post.GetRate()}");
            
            if (opportunity is Bursary bursary)
                Console.WriteLine($"Bursary value -> R{bursary.GetBursaryValue()}");

            if (opportunity is Party party)
                Console.WriteLine($"Entrance fee -> R{party.GetEntranceFee()}");


            Console.WriteLine();
            //switch (opportunity)
            //{
            //    case Post post:
            //        Console.WriteLine($"Rate -> R{post.GetRate()}");
            //        break;
            //    case Bursary bursary:
            //        Console.WriteLine($"Bursary value -> R{bursary.GetBursaryValue()}");
            //        break;
            //    case Party party:
            //        Console.WriteLine($"Entrance fee -> R{party.GetEntranceFee()}");
            //        break;
            //    default:
            //        // case 'opportunity' doesn't match any of the opportunity type.
            //        break;
            //}

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
