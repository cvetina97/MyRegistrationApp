using System;
using System.Collections.Generic;

namespace RegistrationConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 for Registration or 2 for Login!");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    RegisterUser();
                    break;
                case "2":
                    LoginUser();
                    break;
                default:
                    Console.WriteLine("Go fuck yourself!");
                    break;
            }

            //Console.WriteLine("Username");
            //string username = Console.ReadLine();
            //Console.WriteLine("Password");
            //string password = Console.ReadLine();

            //insert data in DB
            
        }

        private static void LoginUser()
        {
            List<string> names = new List<string>()
            {
                "Zaiko Baiko ",
                "Mecho Puh ",
                "Daffy Duck"
            };


            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        private static void RegisterUser()
        {
            throw new NotImplementedException();
        }
    }
}
