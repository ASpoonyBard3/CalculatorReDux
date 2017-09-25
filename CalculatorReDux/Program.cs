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
         static void ParseUserNumber()
        {
            Console.Write("Please enter a number: ");
            string Answer = Console.ReadLine();
            bool valid = false;


            while ()
            if (int.TryParse(Console.ReadLine(), Out Answer))
            {
                    valid = double.TryParse(Console.ReadLine(), out Answer)
            };
            else
            {
                Console.WriteLine("That's not a number\n");
                return Main();
            };


            int number = int.Parse(Answer);
        } 

    }
}
