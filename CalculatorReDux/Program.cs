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
            //Console.ReadLine();

            Console.WriteLine("Enter one Number: ");
            string X = Console.ReadLine();

            Console.WriteLine("Enter second Number: ");
            string Y = Console.ReadLine();

            int FirstInt = int.Parse(X);
            int SecondInt = int.Parse(Y);
            int Result = FirstInt * SecondInt;

            Console.WriteLine("The result is: " + Result);
            Console.ReadLine();


        }
    }
}
