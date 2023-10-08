using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEmployerLab.Models.Utilities
{
    internal class Util
    {
        private static Random random = new Random();

        public static List<string> GenerateRandomNumbers(int count, int min, int max, int length)
        {
            List<string> generatedNumbers = new List<string>();

            for (int i = 0; i < count; i++)
            {
                // Generate a random n-digit number within the specified range
                int randomValue = random.Next(min, max + 1);

                // Format the number as an n-digit string as specified by length
                string formattedNumber = randomValue.ToString("D" + length);

                // Add the generated number to the list
                generatedNumbers.Add(formattedNumber);
            }

            return generatedNumbers;
        }
        //public static string GenerateStudentNumber(int min, int max, int length)
        //{
        //    Random random = new Random();
        //    int randomValue = random.Next(min, max + 1);
        //    string formattedStudentNumber = randomValue.ToString("D" + length);
        //    return formattedStudentNumber;
        //}

        //public static string GenerateStaffNumber(int min, int max, int length)
        //{
        //    Random random = new Random();
        //    char prefix = random.Next(2) == 0 ? 'A' : 'B';
        //    int numericPart = random.Next(min, max + 1);

        //    string formattedNumber = numericPart.ToString("D" + (length - 1)); // Subtract 1 for the prefix
        //    string staffNumber = prefix + formattedNumber;

        //    return staffNumber;
        //}

        //public static string GeneratePostalCode()
        //{
        //    Random random = new Random();
        //    int postalCode = random.Next(1000, 10000);
        //    return postalCode.ToString();
        //}

    }
}
