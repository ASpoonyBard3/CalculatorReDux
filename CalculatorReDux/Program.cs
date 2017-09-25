using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator!");
            Console.WriteLine("==========================");

            Console.Write("Please enter the operator: ");
            string UserOperator = Console.ReadLine();

            Console.Write("How many numbers do you want to " + UserOperator + "? ");
            int Counter = int.Parse(Console.ReadLine());

            //declaring new array numbers as the same size as counter vari
            int[] numbers = new int[Counter];

            for (int index = 0; index < Counter; index++)
            {//conditional code
                Console.Write("Please enter number " + (index + 1) + ": "); // incrementing in the condition and the forloop, why?
                numbers[index] = int.Parse(Console.ReadLine()); // are we capturing the number of numbers here?
            }

            int answer = numbers[0]; //declaring new int var, from the start of the numbers arrays 

            for (int index = 1; index < Counter; index++)
            {
                if (UserOperator == "*")
                {
                    answer = answer * numbers[index];
                }
                else if (UserOperator == "/")
                {
                    answer = answer / numbers[index];
                }
                else if (UserOperator == "+")
                {
                    answer = answer + numbers[index];
                }
                else if (UserOperator == "-")
                {
                    answer = answer - numbers[index];
                }
            };

            Console.WriteLine("The answer is: " + answer);

            Console.ReadLine();
        }
    }
}
