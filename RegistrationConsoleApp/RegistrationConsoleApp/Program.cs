using RegistrationConsoleApp.Models;
using System;
using System.Collections.Generic;

namespace RegistrationConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            User me = new User();


            Console.WriteLine("Press 1 for Registration or 2 for Login!");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Username");
                    string username = Console.ReadLine();
                    Console.WriteLine("Password");
                    string password = Console.ReadLine();
                    RegisterUser(username,password);
                    break;
                case "2":
                    LoginUser();
                    break;
                default:
                    Console.WriteLine("Go fuck yourself!");
                    break;
            }

            

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

        private static void RegisterUser(string email,string password)
        {
            User me = new User();
            me.Email = email;
            me.Password = password;
            Console.WriteLine("Should be inserted in the database!");

            //TODO : add user to db;
        }
    }
}
