using System;
using System.Text;
using System.Text.RegularExpressions;

namespace StudentEmployerLab.Models
{
    internal class User
    {
        public string Firstname { get; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string IDnumber { get; set; }
        public List<Address> Addresses { get; set; }

        public User(string fname, string lastname)
        {
            Firstname = fname;
            Surname = lastname;
            Addresses = new List<Address>();
        }

        public virtual void ValidateUser()
        {
            //Firstname and Surname Validation
            if (!IsValidName(Firstname) || !IsValidName(Surname))
            {
                Console.WriteLine("Invalid name or surname");
            }

            //ID Number validation
            if (!IsValidIDNumber(IDnumber))
            {
                Console.WriteLine("Invalid ID number");
            }

            //Phone Number validation 
            if (!IsValidPhoneNumber(PhoneNumber))
            {
                Console.WriteLine("Invalid phone number");
            }

            ////Email validation
            //if (!IsValidEmail(EmailAddress))
            //{
            //    Console.WriteLine("Invalid email address");
            //}
        }

        //Get FullName
        //public string GetFullName(ref string firstName, ref string lastName)
        //{
        //    if (!string.IsNullOrEmpty(Firstname) && !string.IsNullOrEmpty(Surname))
        //    {
        //        StringBuilder sb = new StringBuilder();
        //        sb.Append($"Name: {Firstname} {Surname}");
        //        return sb.ToString();
        //    }
        //    return "No names provided";
        //}
        public bool GetFullName(ref string firstName, ref string lastName)
        {
            if (!string.IsNullOrEmpty(Firstname) && !string.IsNullOrEmpty(Surname))
            {
                firstName = Firstname;
                lastName = Surname;
                StringBuilder sb = new StringBuilder();
                sb.Append($"Name: {Firstname} {Surname}");
                Console.WriteLine(sb.ToString());
                return true;
            }
            else
            {
                firstName = lastName = null;
                return false;
            }
        }


        //VALIDATION METHODS

        //Firstname and Surname Validation
        private bool IsValidName(string name)
        {
            return !string.IsNullOrEmpty(name) && !Regex.IsMatch(name, @"[^A-Za-z]") && !name.Contains(" ") && name.Length >= 3;

        }

        //ID Number validation
        private bool IsValidIDNumber(string idNumber)
        {
            return !string.IsNullOrEmpty(idNumber) && idNumber.Length == 13 && Regex.IsMatch(idNumber, @"^\d+$");//Also checking if the charecteres are only numbers(0-9)
        }

        //Phone Numver validation
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return !string.IsNullOrEmpty(phoneNumber) && Regex.IsMatch(phoneNumber, @"^0\d{9}$");
        }

        //Email Validation
        //private bool IsValidEmail(string email)
        //{
        //    return !string.IsNullOrEmpty(email) && Regex.IsMatch(email, @"^\w+@\w+\.\w+$");
        //}

    }
}
