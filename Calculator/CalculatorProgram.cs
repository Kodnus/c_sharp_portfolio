using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class CalculatorProgram
    {
        static void Main(string[] args)
        {

            //Write a primitive calculator that calculates two numbers

            //Our two numbers to be calculated
            int num1 = 0, num2 = 0;

            //While this is true, our do/while loop runs
            Boolean needAnswer = true;

            Console.WriteLine("Console calculator!");

            //Type number 1
            Console.WriteLine("Type a number and press enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            //Type number 2
            Console.WriteLine("Type another number and press enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            //Possible calulations
            Console.WriteLine("Choose an option from the list:");
            Console.WriteLine("Add");
            Console.WriteLine("Subtract");
            Console.WriteLine("Multiply");
            Console.WriteLine("Divide");
            Console.Write("Your option? ");

            
            do
            {
                //Switch selection-statement where each jump-case has three cases to make it easier for user
                switch (Console.ReadLine().ToLower())
                {
                    case "a":
                    case "add":
                    case "1":
                        Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                        needAnswer = false;
                        break;
                    case "s":
                    case "subtract":
                    case "2":
                        Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                        needAnswer = false;
                        break;
                    case "m":
                    case "multiply":
                    case "3":
                        Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                        needAnswer = false;
                        break;
                    case "d":
                    case "divide":
                    case "4":
                        //Checking for divition by 0
                        if (num1 == 0 || num2 == 0)
                        {
                            Console.WriteLine("Cannot divide by zero!");
                        }
                        else
                        {
                            Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                            needAnswer = false;
                        }
                        break;
                    //our default jump case incase user does not hit a correct input
                    default:
                        Console.WriteLine("Please provide an input from the list");
                        break;
                }
            } while (needAnswer);


            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}
