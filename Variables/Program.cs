// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int x;
            int y;
            x= 5;
            y= x + 10;
            Console.WriteLine(y);
            Console.ReadLine();
            */
            Console.WriteLine("What is your name?");
            Console.WriteLine("Type your first name:");
            string myFirstName;
            myFirstName = Console.ReadLine();

            string myLastName;
            Console.WriteLine("Type in your last name:");
            myLastName = Console.ReadLine();

            Console.WriteLine($"Hello {myFirstName} {myLastName}");
            Console.ReadLine();



        }
    }
}