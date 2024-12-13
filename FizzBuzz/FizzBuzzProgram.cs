using System;

namespace FizzBuzz
{
    internal class FizzBuzzProgram
    {
        static void Main(string[] args)
        {
            //For loop from 1 to 15
            //3 and 5 FizzBuzz
            //3 Fizz
            //5 Buzz
            //else = number

            /*
                
            */



            //loop starts at 1 instead of 0
            for (int i = 1; i <= 15; i++)
            {
                //Modulo divides the numbers and returns what is remained
                //Two conditions needs to be met for FizzBuzz
                //Where i is both divided by 3 and 5 with 0 remained by modulo - in this case only 15
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0) { Console.WriteLine("Fizz"); }

                else if (i % 5 == 0) { Console.WriteLine("Buzz"); }


                else { Console.WriteLine(i); }
            }


            Console.ReadLine();

        }
    }
}
