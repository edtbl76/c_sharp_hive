// See https://aka.ms/new-console-template for more information
using System;

namespace PasswordChecker
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            const int minLength = 8;
            const string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lowercase = "abcdefghijklmnopqrstuvwxyz";
            const string digits = "0123456789";
            const string specialChars = "@#?!";
            
            Console.Write("Please enter your password: ");
            var password = Console.ReadLine();

            var score = 0;

            // Check Minimum Length
            if (password is {Length: >= minLength})
            {
                score++;
            }
            else
            {
                Console.WriteLine("Password doesn't meet minimum length.");
            }
            
            // Check Uppercase
            if (password != null && Tools.Contains(password, uppercase))
            {
                score++;
            }
            else
            {
                Console.WriteLine("Password doesn't contain uppercase characters");
            }
            
            // Check lowercase
            if (password != null && Tools.Contains(password, lowercase))
            {
                score++;
            }
            else
            {
                Console.WriteLine("Password doesn't contain lowercase characters.");
            }

            // Check digits
            if (password != null && Tools.Contains(password, digits))
            {
                score++;
            }
            else
            {
                Console.WriteLine("Password doesn't contain numeric characters.");
            }
            
            // Check special characters
            if (password != null && Tools.Contains(password, specialChars))
            {
                score++;
            }
            else
            {
                Console.WriteLine("Password doesn't contain special characters");
            }

            var strength = score switch
            {
                >= 4 => "extremely strong",
                3 => "strong",
                2 => "medium",
                1 => "weak",
                _ => "WTF?"
            };

            Console.WriteLine($"Password Score: {score} [{strength}]");
        }
    }
}