using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExamples
{
    using System;
    using System.Collections.Generic;

    class Assign2
    {
        static void Main(string[] args)
        {
            // Generate a random OTP of length 6
            string otp = GenerateOTP(6);

            Console.WriteLine("Generated OTP: " + otp);
        }

        static string GenerateOTP(int length)
        {
            // Define the characters to be used for generating OTP
            string chars = "0123456789";

            // Create a random number generator
            Random rand = new Random();

            // Use a list to store the OTP characters
            List<char> otpChars = new List<char>();

            // Generate OTP characters
            for (int i = 0; i < length; i++)
            {
                // Get a random index to select a character from 'chars'
                int index = rand.Next(chars.Length);
                // Add the selected character to the OTP list
                otpChars.Add(chars[index]);
            }

            // Convert the list of characters to a string and return
            return new string(otpChars.ToArray());
        }
    }

}
