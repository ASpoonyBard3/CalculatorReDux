﻿using System;
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

            //note that Console.Read only takes a single char.
            

            Console.WriteLine("======================");
            Console.WriteLine("Please enter the desired operator:" UserOperator);
            //collect user input and assign to a variable

            Console.WriteLine("Enter one Number: ");
            string X = Console.ReadLine();

            Console.WriteLine("Enter second Number: ");
            string Y = Console.ReadLine();

            int FirstInt = int.Parse(X);
            int SecondInt = int.Parse(Y);
            
            if (UserOperator == "+")
                Result = FirstInt + SecondInt;
            else if (UserOperator == "-")
                Result = FirstInt - SecondInt;
            else if (UserOperator == "*")
                Result = FirstInt * SecondInt;
            else if (UserOperator == "/")
                Result = FirstInt / SecondInt;
            else
                {
                Operator = "You didn't chose a valid operator."; 
                }

            Console.WriteLine("The result is: " + Result);
            Console.ReadLine();


        }
    }
}
