using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is my First Console App");
            Console.WriteLine("What is your name?");
            string response = Console.ReadLine();
            Console.WriteLine($"Hello {response}!");
        }
    }
}
