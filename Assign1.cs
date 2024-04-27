using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExamples
{
   
    class Assign1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Email:");
            string email = Console.ReadLine();

            if (IsValidEmail(email))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

      public  static bool IsValidEmail(string email)
        {
            // Check if the email contains '@' and '.'
            if (email.Contains("@") && email.Contains("."))
            {
                // Check if '@' appears before '.'
                int atIndex = email.IndexOf("@");
                int dotIndex = email.IndexOf(".");
                if (atIndex < dotIndex)
                {
                    // Check if there is at least one character before '@'
                    if (atIndex > 0)
                    {
                        // Check if there is at least one character between '@' and '.'
                        if (dotIndex - atIndex > 1)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }

}
