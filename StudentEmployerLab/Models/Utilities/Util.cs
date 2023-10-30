using StudentEmployerLab.Interfaces;
using DataList = StudentEmployerLab.Data.Data;

namespace StudentEmployerLab.Models.Utilities
{
    internal class Util
    {
        public Random Random = new Random();
        DataList data = new DataList();
        
        /*------------------------------------GenerateRandomNumbers--------------------------------------*/

        public List<string> GenerateRandomNumbers(int count, int min, int max, int length)
        {
            List<string> generatedNumbers = new List<string>();

            for (int i = 0; i < count; i++)
            {
                // Generate a random n-digit number within the specified range
                int randomValue = Random.Next(min, max + 1);

                // Format the number as an n-digit string as specified by length
                string formattedNumber = randomValue.ToString("D" + length);

                // Add the generated number to the list
                generatedNumbers.Add(formattedNumber);
            }

            return generatedNumbers;
        }

        /*------------------------------------GenerateRandomNumber--------------------------------------*/

        public string GenerateRandomNumber(int length)
        {
            if (length > 9)
            {
                Console.WriteLine("The maximum number that can be generated is 9! ");
                return null;
            }

            string minNumber = new string("111111111");

            string maxNumber = new string("999999999");

            int min = int.Parse(minNumber.Substring(0, length));

            int max = int.Parse(maxNumber.Substring(0, length));

            Random random = new Random();

            // Generate a random n-digit number within the specified range 
            int randomValue = random.Next(min, max + 1);

            // Format the number as an n-digit string as specified by lenghth 
            return randomValue.ToString("D" + length);
        }

        /*------------------------------------GenerateRandomAmount--------------------------------------*/

        public decimal GenerateRandomAmount(int length)
        {
            if (length > 9)
            {
                Console.WriteLine("The maximum number that can be generated is 9! ");
                return 0.00m;
            }

            string minNumber = new string("111111111");

            int min = int.Parse(minNumber.Substring(0, length));

            Random random = new Random();

            // Generate a random n-digit number within the specified range 
            decimal amount = (decimal)(random.NextDouble() * min);

            return Math.Round(amount, 2);
        }
        /*-----------------------------------AssignOpportunities------------------------------------*/

        public bool AssignOpportunities(Employer employer)
        {
            if (employer == null)
            {
                Console.WriteLine("User cannot be null");
                return false;
            }

            //CREATE RANDOM NUMBER OF Opportunities

            int NumberOfOpportunities = Random.Next(1, 6);

            for (int i = 0; i < NumberOfOpportunities; i++) // Assign 1 to 5 opportunities
            {
                int randomIndex = Random.Next(20);
                int opportunityType = Random.Next(3); // 0, 1, or 2

                switch (opportunityType)
                {
                    case 0:
                        
                        Post post = new Post(data.CompanyNames[randomIndex], data.JobDescription[randomIndex],
                                    data.Department[randomIndex], data.StartDates[randomIndex], data.Rates[randomIndex]);

                        employer.CreatePost(post);

                        break;
                    case 1:

                        Bursary bursary = new Bursary(data.CompanyNames[randomIndex], data.JobDescription[randomIndex],
                                          data.Department[randomIndex], data.StartDates[randomIndex], data.Rates[randomIndex]);

                        employer.CreateBursary(bursary);

                        break;
                    default:

                        Party party = new Party(data.PartyNames[randomIndex], data.JobDescription[randomIndex],
                                      data.Department[randomIndex], data.StartDates[randomIndex], data.Rates[randomIndex]);

                        employer.CreateParty(party);
                        break;
                }
            }

            return true;

        }

            /*------------------------------------AssignAddresses--------------------------------------*/

       public bool AssignAddresses(User user)
       {
            if (user == null)
            {
                Console.WriteLine("User cannot be null");
                return false;
            }

            //EMPTY LIST THAT WILL BE USED TO ENSURE THERE ARE NO REPITATIONS OF ADDRESSNAME IN EACH USER
            HashSet<string> uniqueAddressNames = new HashSet<string>();

            //CREATE RANDOM NUMBER OF ADDRESSES
            int NumberOfAddresses = Random.Next(1, 4);

            //ASSIGN ADDRESSES
            for (int i = 0; i < NumberOfAddresses; i++) // Assign 1 to 3 addresses
            {
                int randomIndex;
                string addressName;

                // Ensure that each AddressName is unique within the user's addresses
                do
                {
                    randomIndex = Random.Next(data.AddressNames.Count);
                    addressName = data.AddressNames[randomIndex];
                }
                while (!uniqueAddressNames.Add(addressName));

                var address = new Address
                {
                    AddressName = addressName,
                    Street = data.StreetNames[Random.Next(data.StreetNames.Count)],
                    CityOrTown = data.Cities[Random.Next(data.Cities.Count)],
                    Province = data.Provinces[Random.Next(data.Provinces.Count)],
                    PostalCode = GenerateRandomNumber(4)
                };

                user.Addresses.Add(address);
            }
            return true;
        }

        /*------------------------------------GetAorB--------------------------------------*/

        public string GetAorB()
        {
            // Generate a random number (0 or 1)
            int randomValue = Random.Next(2);

            // Return "A" if the random number is 0, or "B" if it's 1
            return randomValue == 0 ? "A" : "B";
        }

        /*------------------------------------StudentCount--------------------------------------*/

        public void StudentCount(int count)
        {
            Console.WriteLine($"--------------------------------------- Student {count}: -------------------------------------------");
            Console.WriteLine();
        }

        /*------------------------------------GenerateUsers--------------------------------------*/

        public IEnumerable<User> GenerateUsers(List<IOpportunity> opportunities, List<Address> addresses)
        {
            List<User> generatedUsers = new List<User>();
            List<string> StudentNumbers = GenerateRandomNumbers(20, 10000000, 99999999, 8);
            List<string> StuffNumbers = GenerateRandomNumbers(20, 1000000, 9999999, 7);


            // ADD EMPLOYERS TO LIST OF USERS
            for (int i = 0; i < 3; i++)
            {
                string StaffNumberPrefix = GetAorB();

                Employer employer = new Employer(data.FirstNames[i], data.Surnames[i], addresses, StaffNumberPrefix + StuffNumbers[i], opportunities);

                employer.SetIDNumber(data.SAIDs[i]);
                employer.SetPhoneNumber(data.telephoneNumbers[i]);

                if (!AssignAddresses(employer))
                {
                    Console.WriteLine("Unable to assign address to employer");
                }

                if (!AssignOpportunities(employer))
                {
                    Console.WriteLine("Unable to assign opportunities to employer");
                }

                generatedUsers.Add(employer);
            }

            // ADD STUDENTS TO LIST OF USERS
            for (int i = 4; i < 7; i++)
            {
                Student student = new Student(data.FirstNames[i], data.Surnames[i], addresses, StudentNumbers[i]);

                student.SetIDNumber(data.SAIDs[i]);
                student.SetPhoneNumber(data.telephoneNumbers[i]);

                if (!AssignAddresses(student))
                {
                    Console.WriteLine("Unable to assigning address to student");
                }

                generatedUsers.Add(student);
            }

            return generatedUsers;
        }
    }
}
