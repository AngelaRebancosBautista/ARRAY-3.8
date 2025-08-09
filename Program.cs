using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAY_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] passwords = new string[4];

            Console.WriteLine("Enter 4 passwords");

            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Password {i + 1}: ");
                passwords[i] = Console.ReadLine();
            }
            Console.WriteLine("\nPassword Validation Results");
            foreach (string password in passwords)
            {
                bool isValid = ValidatePassword(password);
                Console.WriteLine($"Password: {password} - " + (isValid ? "Valid" : "Invalid"));
            }
        }
        static bool ValidatePassword(string password)
        {
            if (password.Length < 6)
            {
                return false;
            }

            bool hasUppercase = false;
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    hasUppercase = true;
                    break;
                }
            }
            return hasUppercase;
        }
    }
}
        
        
