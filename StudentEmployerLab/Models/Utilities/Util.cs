using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
       public static bool AssignAddresses(User user, List<string> streetNames, List<string> cities, List<string> provinces, List<string> addressNames)
        {
            if (user == null || streetNames == null || cities == null || provinces == null || addressNames == null)
            {
                Console.WriteLine("Data lists cannot be empty");
                return false;
            }

            //EMPTY LIST THAT WILL BE USED TO ENSURE THERE ARE NO REPITATIONS OF ADDRESSNAME IN EACH USER
            HashSet<string> uniqueAddressNames = new HashSet<string>();

            //CREATE RANDOM NUMBER OF ADDRESSES
            int NumberOfAddresses = Random.Next(1, 4);

            //ASSIGN ADDRESSES
            for (int i = 0; i < NumberOfAddresses; i++) // Assign 1 to 3 addresses
            {
                int randomIndex = Random.Next(addressNames.Count);
                string addressName = addressNames[randomIndex];

                // Ensure that each AddressName is unique within the user's addresses
                while (!uniqueAddressNames.Add(addressName))
                {
                    randomIndex = Random.Next(addressNames.Count);
                    addressName = addressNames[randomIndex];
                }
                var address = new Address
                {
                    AddressName = addressName,
                    Street = streetNames[Random.Next(streetNames.Count)],
                    CityOrTown = cities[Random.Next(cities.Count)],
                    Province = provinces[Random.Next(provinces.Count)],
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
