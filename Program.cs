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
            }
        }
    }
}