using System;
using System.Collections.Generic;

namespace RegistrationConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>()
            {
                "Zaiko Baiko ",
                "Mecho Puh ",
                "Daffy Duck"
            };


            foreach(var name in names)
            {
                Console.WriteLine(name);
            }

            
        }
    }
}
