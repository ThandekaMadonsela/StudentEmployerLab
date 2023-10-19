using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentEmployerLab.Data;
using DataList = StudentEmployerLab.Data.Data;

namespace StudentEmployerLab.Models.Utilities
{
    internal class Util
    {
        public static Random Random = new Random();

        public static List<string> GenerateRandomNumbers(int count, int min, int max, int length)
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
       public static bool AssignAddresses(User user)
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
                    randomIndex = Random.Next(DataList.AddressNames.Count);
                    addressName = DataList.AddressNames[randomIndex];
                }
                while (!uniqueAddressNames.Add(addressName));

                var address = new Address
                {
                    AddressName = addressName,
                    Street = DataList.StreetNames[Random.Next(DataList.StreetNames.Count)],
                    CityOrTown = DataList.Cities[Random.Next(DataList.Cities.Count)],
                    Province = DataList.Provinces[Random.Next(DataList.Provinces.Count)],
                    PostalCode = GenerateRandomNumbers(1, 1000, 9999, 4)[0]
                };

                user.Addresses.Add(address);
            }
            return true;
       }
        public static string GetAorB()
        {
            // Generate a random number (0 or 1)
            int randomValue = Random.Next(2);

            // Return "A" if the random number is 0, or "B" if it's 1
            return randomValue == 0 ? "A" : "B";
        }
    }
}
