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
            /*
            Console.WriteLine("Bobs big giveaway");
            Console.Write("Choose a door: 1, 2, or 3: ");
            string userInput = Console.ReadLine();
            string message = "";
            if (userInput =="1")
            {
                message = "You won a new car!"; 
            }
            else if (userInput == "2")
            {
                message = "You won a new boat!";
            }
            else if (userInput == "3")
            {
                message = "You won a new cat!";

            }
            else
            {
                message = "Sorry, we didn't understand. ";
                //message = message + "You lose.";
                message += "You lose.";
            }
            Console.WriteLine(message);
            Console.ReadLine();
            */
            Console.WriteLine("Bobs big giveaway");
            Console.Write("Choose a door: 1, 2, or 3: ");
            string userInput = Console.ReadLine();

            string message = (userInput == "1") ? "You won a new car!" :
                             (userInput == "2") ? "You won a new boat!" :
                             (userInput == "3") ? "You won a new cat!" :
                             "Sorry, we didn't understand. You lose.";
            //Console.WriteLine(message); 
            Console.WriteLine("You entered:{0}, therefore {1} ", userInput, message);
            Console.ReadLine();
        }
    }
}