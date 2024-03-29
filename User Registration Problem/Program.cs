﻿using System;
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
                Console.WriteLine("\nSelect your option: ");
                Console.WriteLine("1. Check First name starts with Cap and has minimum 3 characters");
                Console.WriteLine("2. Check Last name starts with Cap and has minimum 3 characters");
                Console.WriteLine("3. Check Email address is valid or not");
                Console.WriteLine("4. Check Mobile Number is valid or not");
                Console.WriteLine("5. Check Password is valid or not.");
                Console.WriteLine("0. Exit");

                Console.Write("=> ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter your first name: ");
                        string FirstName = Console.ReadLine();

                        try
                        {
                            if (ValidFirstName.FirstName(FirstName))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Valid");
                                Console.ResetColor();
                            }
                        }
                        catch (InvalidUserDetails ex)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("An exception occurred: " + ex.Message);
                            Console.ResetColor();
                        }

                        break;

                    case 2:
                        Console.WriteLine("Enter your last name: ");
                        string LastName = Console.ReadLine();

                        try
                        {
                            if (ValidLastName.LastName(LastName))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Valid");
                                Console.ResetColor();
                            }
                        }
                        catch (InvalidUserDetails ex)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("An exception occurred: " + ex.Message);
                            Console.ResetColor();
                        }
                        
                        break;

                    case 3:
                        Console.WriteLine("Enter your email: ");
                        string Email = Console.ReadLine();

                        try
                        {
                            if (ValidEmail.Email(Email))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Valid");
                                Console.ResetColor();
                            }
                        }
                        catch (InvalidUserDetails ex)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("An exception occurred: " + ex.Message);
                            Console.ResetColor();
                        }

                        break;

                    case 4:
                        Console.WriteLine("Enter your Phone Number: ");
                        string PhoneNumber = Console.ReadLine();

                        try
                        {
                            if (ValidPhoneNumber.IndianPhoneNumber(PhoneNumber))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Valid");
                                Console.ResetColor();
                            }
                        }
                        catch (InvalidUserDetails ex)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("An exception occurred: " + ex.Message);
                            Console.ResetColor();
                        }

                        break;

                    case 5:
                        Console.WriteLine("Enter your Password: ");
                        string Password = Console.ReadLine();

                        try
                        {
                            if (ValidPassword.Password(Password))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Valid");
                                Console.ResetColor();
                            }
                        }
                        catch (InvalidUserDetails ex)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("An exception occurred: " + ex.Message);
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
