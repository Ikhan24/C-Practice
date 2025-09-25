// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForIterations
{
    class Program
    {
        static void Main(string[] args)
        {
           for (int i = 0; i < 10; i++)
           {
                //Console.WriteLine(i);
                if (i == 5)
                {
                    Console.WriteLine("Found 5");
                    break;
                }   
            }
           Console.ReadLine();
        }
    }
}