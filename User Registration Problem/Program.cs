using System;
using System.Text.RegularExpressions;
using User_Registration_Problem;

namespace Regex_Practice
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
            Regex or regular expressions
            A regular expression is a pattern that could be matched against an input text.
            It is maching with the given pattern.
            brackets-[], {}, ()
            carret - ^ --> start of the expression
            dollar - $ --> end of the expression
            */

            // string namePattern ="^[a-z]{6,}$";

            // string namePattern = "^[0-9]{5}Hello";

            // string webUrl = "^[w]{3}[.][a-z]{3,}[.][a-z]{2,}";

            while (true)
            {
                Console.WriteLine("Select your option: ");
                Console.WriteLine("1. Check First name starts with Cap and has minimum 3 characters");
                Console.WriteLine("0. Exit");

                Console.Write("=> ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter your first name: ");
                        string FirstName = Console.ReadLine();
                        Console.WriteLine(FirstName);

                        if (ValidFirstName.FirstName(FirstName))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Valid");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid");
                            Console.ResetColor();
                        }
                        break;

                    case 0:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Enter valid option.");
                        break;
                }
            }
        }
    }
}
