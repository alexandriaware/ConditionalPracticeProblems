using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalPracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Problem 1
            //Console.WriteLine("Please enter a number");
            //int firstNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please enter a second number");
            //int secondNumber = int.Parse(Console.ReadLine());

            //if (firstNumber == secondNumber)
            //{
            //    Console.WriteLine("The numbers " + firstNumber + " and " + secondNumber + " are the same number.");
            //}
            //else if (firstNumber != secondNumber)
            //{
            //    Console.WriteLine("The numbers " + firstNumber + " and " + secondNumber + " are not equal to each other.");
            //}


            ////Problem 2
            //Console.WriteLine("Please enter a number");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("The number " + number + " is an even number.");
            //}
            //else
            //{
            //    Console.WriteLine("The number " + number + " is an odd number.");
            //}


            //Problem 3
            Console.WriteLine("Please enter a number");
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("The number " + number + " is a negative number.");
            }
            else if (number == 0)
            {
                Console.WriteLine("The number 0 is a neutral number.");
            }
            else
            {
                Console.WriteLine("The number " + number + " is a positive number.");
            }



        }
    }
}
