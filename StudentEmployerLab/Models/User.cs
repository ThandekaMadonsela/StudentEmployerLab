using System;
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

        public User(string fname, string lastname)
        {
            Firstname = fname;
            Surname = lastname;
        }

        public virtual void ValidateUser()
        {
            //Firstname and Surname Validation
            if (!IsValidName(Firstname) || !IsValidName(Surname))
            {
                throw new ArgumentException("Invalid name or surname");
            }

            //ID Number validation
            if (!IsValidIDNumber(IDnumber))
            {
                throw new ArgumentException("Invalid ID number");
            }

            //Phone Number validation 
            if (!IsValidPhoneNumber(PhoneNumber))
            {
                throw new ArgumentException("Invalid phone number");
            }

            //Email validation
            if (!IsValidEmail(EmailAddress))
            {
                throw new ArgumentException("Invalid email address");
            }
        }

        //Get FullName
        public bool GetFullName(ref string firstName, ref string lastName)
        {
            if (!string.IsNullOrEmpty(Firstname) && !string.IsNullOrEmpty(Surname))
            {
                firstName = Firstname;
                lastName = Surname;
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
            return !string.IsNullOrEmpty(name) && !Regex.IsMatch(name, @"[^A-Za-z]");
        }

        //ID Number validation
        private bool IsValidIDNumber(string idNumber)
        {
            return !string.IsNullOrEmpty(idNumber) && idNumber.Length == 13 && Regex.IsMatch(idNumber, @"^\d+$");
        }

        //Phone Numver validation
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return !string.IsNullOrEmpty(phoneNumber) && Regex.IsMatch(phoneNumber, @"^0\d{9}$");
        }

        //Email Validation
        private bool IsValidEmail(string email)
        {
            return !string.IsNullOrEmpty(email) && Regex.IsMatch(email, @"^\w+@\w+\.\w+$");
        }
    }
}
