using System;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;

namespace StudentEmployerLab.Models
{
    internal class User
    {
        private string FirstName;
        private string Surname;
        private string PhoneNumber;
        private string EmailAddress;
        private string IDnumber;
        public List<Address> Addresses { get; set; }

        public User(string fname, string lastname)
        {
            SetFirstName(fname);
            SetSurname(lastname);
            Addresses = new List<Address>();
        }

        public virtual bool ValidateUser()
        {
            //Firstname and Surname Validation
            if (!IsValidName(FirstName) || !IsValidName(Surname))
                return false;

            //ID Number validation
            if (!IsValidIDNumber(IDnumber))
                return false;

            //Phone Number validation 
            if (!IsValidPhoneNumber(PhoneNumber))
                return false;

            //Email validation
            if (!IsValidEmail(EmailAddress))
                return false;

            //All Valid
            return true;
        }

        //GET FULLNAME
        public bool GetFullName(out string firstName, out string lastName)
        {
           
            if (string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(Surname))
            {
                Console.WriteLine("First name or surname is empty");
                firstName = lastName = null;
                return false;
            }
            //If not null
            firstName = FirstName;
            lastName = Surname;
            return true;
        }

        //SETTERS
        public bool SetFirstName(string value)
        {
            if (!IsValidName(value))
                return false;
            
            //If valid
            FirstName = value;
            return true;
        }

        public bool SetSurname(string value)
        {
            if (!IsValidName(value))
                return false;

            //If valid
            Surname = value;
            return true;
        }

        public bool SetPhoneNumber(string value)
        {
            if (!IsValidPhoneNumber(value))
                return false;

            //If valid
            PhoneNumber = value;
            return true;
        }

        public bool SetEmailAddress(string value)
        {
            if (!IsValidEmail(value))
                return false;

            //If valid
            EmailAddress = value;
            return true;
        }

        public bool SetIDNumber(string value)
        {
            if (!IsValidIDNumber(value))
                return false;

            //If valid
            IDnumber = value;
            return true;
        }

        //GETTERS
        public string GetPhoneNumber()
        {
            return PhoneNumber;
        }

        public string GetEmailAddress()
        {
            return EmailAddress;
        }

        public string GetIDNumber()
        {
            return IDnumber;
        }


        //VALIDATION METHODS

        //Firstname and Surname Validation
        private bool IsValidName(string name)
        {
            Console.WriteLine("Invalid name or surname");
            return !string.IsNullOrEmpty(name) && !Regex.IsMatch(name, @"[^A-Za-z]") && !name.Contains(" ") && name.Length >= 3;
        }

        //ID Number validation
        private bool IsValidIDNumber(string idNumber)
        {
            Console.WriteLine("Invalid ID number");
            return !string.IsNullOrEmpty(idNumber) && idNumber.Length == 13 && Regex.IsMatch(idNumber, @"^\d+$");//Also checking if the charecteres are only numbers(0-9)
        }

        //Phone Numver validation
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            Console.WriteLine("Invalid phone number");
            return !string.IsNullOrEmpty(phoneNumber) && Regex.IsMatch(phoneNumber, @"^0\d{9}$");
        }

        //Email Validation
        private bool IsValidEmail(string email)
        {
            Console.WriteLine("Invalid email address");
            return !string.IsNullOrEmpty(email) && Regex.IsMatch(email, @"^\w+@\w+\.\w+$");
        }

    }
}

