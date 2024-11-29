using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace LoginSystem
{
    class Program
    {
        static Dictionary<string, string> userDatabase = new Dictionary<string, string>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        RegisterUser();
                        break;
                    case "2":
                        LoginUser();
                        break;
                    case "3":
                        Console.WriteLine("Goodbye");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again!");
                        break;
                }
            }
        }

        static void RegisterUser()
        {
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();

            string hashedPassword = HashPassword(password);
            userDatabase[username] = hashedPassword;

            Console.WriteLine("User registered successfully!");
        }


    }
}