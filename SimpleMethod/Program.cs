using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            //before using helper methods
            

            Console.WriteLine("The Name Game");

            Console.Write("What's your first name? ");
            string fName = Console.ReadLine();

            Console.Write("What's your last name? ");
            string lName = Console.ReadLine();

            Console.Write("What's your city? ");
            string city = Console.ReadLine();

            char[] fNameArray = fName.ToCharArray();
            Array.Reverse(fNameArray);

            char[] lNameArray = lName.ToCharArray();
            Array.Reverse(lNameArray);

            char[] cityArray = city.ToCharArray();
            Array.Reverse(cityArray);
            /*
            string result = "";

            foreach (char item in fNameArray)
            {
                result += item;
            }

            foreach (char item in lNameArray)
            {
                result += item;
            }

            foreach (char item in cityArray)
            {
                result += item;
            }
            */
            /*
            int[] numbers = new int[7] { 1, 4, 6, 76, 56, 7, 87 };
            //Array.Sort(numbers);
            SelectionSort(numbers);

            /*
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            */
            /*
            Console.WriteLine(string.Join(",", numbers));
            Console.ReadLine();
            /*
            Console.WriteLine("Results: " + result);
            Console.ReadLine();
            */

            //Using ReverseString helper method
            /*
            Console.Write("Results: ");
            ReverseString(fName);
            ReverseString(lName);   
            ReverseString(city);
            */
            
            //Using ReverseString2 helper method
            Console.Write("Results: ");
            
            string reversedFName = ReverseString2(fName);
            string reversedLName = ReverseString2(lName);   
            string reversedCity = ReverseString2(city);
            /*
            Console.Write(String.Format("{0} {1} {2}",
                reversedFName,
                reversedLName, 
                reversedCity));

            */

            //Using DisplayResult helper method
            DisplayResult(
                reversedFName,
                reversedLName, 
                reversedCity);
            Console.WriteLine();

            //Using DisplayResult helper method version 2

            DisplayResult(reversedFName + " " + reversedLName + " " + reversedCity);
            Console.ReadLine();
        }



        
        public static void ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            foreach (char item in messageArray)
            {
                Console.Write(item) ;
            }
            Console.Write(" ");
        }
        private static string ReverseString2(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return String.Concat(messageArray);
        }

        private static void DisplayResult(
            string reversedFName, 
            string reversedLName, 
            string reversedCity)
        {
            Console.Write(String.Format("{0} {1} {2}",
                reversedFName,
                reversedLName,
                reversedCity));
        }


        private static void DisplayResult(string message)
        {
            Console.Write("Results: ");
            Console.WriteLine(message);
        }



        public static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
    }
    
}