using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator!");
            Console.WriteLine("======================");

            Console.WriteLine("Please enter the desired operator:");
            String UserOperator = Console.ReadLine();

            //why does it work this way??
            Console.Write("Please enter numbers " + UserOperator + "? ");
            //the line below takes the userOperator variable from the user and converts it 
            int count = int.Parse(Console.ReadLine());

            int[] numbers = new int[count];
            for (int index = 0; index < count; index++)
            {
                Console.Write("Please enter number " + (index + 1) + ":");
                numbers[index] = int.Parse(Console.ReadLine());
            }

            int Result = numbers[0];

            for (int index = 1; index < count; index++)
            {
                if (UserOperator == "+")
                {
                    Result = Result + Result;
                }
                else if (UserOperator == "-")
                {
                    Result = Result - Result;
                }
                else if (UserOperator == "*")
                {
                    Result = Result * Result;
                }
                else if (UserOperator == "/")
                {
                    Result = Result / Result;
                }
            }
            Console.WriteLine("The answer is: " + Result);
            Console.ReadLine();
        }
    }
}