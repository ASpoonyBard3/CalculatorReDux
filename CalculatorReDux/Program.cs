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

            int[] numbers = new int[Counter];
            for (int index = 0; index < Counter; index++)
            {
                Console.Write("Please enter number " + (index + 1) + ": ");
                numbers[index] = int.Parse(Console.ReadLine());
            }

            int answer = numbers[0];

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
