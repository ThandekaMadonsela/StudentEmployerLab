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
            FirstName = fname;
            Surname = lastname;
            Addresses = new List<Address>();
        }

        public virtual bool ValidateUser()
        {
            //Firstname and Surname Validation
            //if (!IsValidName(FirstName,"name") || !IsValidName(Surname, "surname"))
            //    return false;

            //ID Number validation
            if (!IsValidIDNumber(IDnumber))
                return false;

            //Phone Number validation 
            if (!IsValidPhoneNumber(PhoneNumber))
                return false;

            //Email validation
            //if (!IsValidEmail(EmailAddress))
            //    return false;

            //All Valid
            return true;
        }

        //GET FULLNAME
        public bool GetFullName(out string firstName, out string lastName)
        {
           
            if (string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(Surname))
            {
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
            return (!IsValidName(value, ref FirstName));
        }

        public bool SetSurname(string value)
        {
            return (!IsValidName(value, ref Surname));
        }
        
        public void SetPhoneNumber(string value)
        {
           
            PhoneNumber = value;
        }

        public void SetEmailAddress(string value)
        {
            EmailAddress = value;
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
        private bool IsValidName(string name, ref string nameType)
        {
            if(string.IsNullOrEmpty(name) ||  name.Contains(" ") || name.Length <= 3)
            {
                Console.WriteLine($"The {nameType} {name} is invalid");
                return false;
            }
            nameType = name;
            //If valid
            return true;
        }

        //ID Number validation
        private bool IsValidIDNumber(string idNumber)
        {
           
            if(string.IsNullOrEmpty(idNumber) || idNumber.Length != 13)//!Regex.IsMatch(idNumber, @"^\d+$")
            {
                Console.WriteLine($"The ID number {idNumber} is invalid");
                return false;
            }

            //If valid
            return true;
        }

        //Phone Numver validation
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            
            if(string.IsNullOrEmpty(phoneNumber) || !Regex.IsMatch(phoneNumber, @"^0\d{9}$"))
            {
                Console.WriteLine($"The phone number {phoneNumber}  is invalid");
                return false;
            }

            //If valid
            return true;
        }

        //Email Validation
        private bool IsValidEmail(string email)
        {
           
            if(string.IsNullOrEmpty(email) || !Regex.IsMatch(email, @"^\w+@\w+\.\w+$"))
            {
                Console.WriteLine($"The email {email} address");
                return false;
            }

            //If valid
            return true;
        }

    }
}

