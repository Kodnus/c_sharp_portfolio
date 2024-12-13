using System;

namespace TimeTable
{
    internal class TimeTableProgram
    {
        static void Main(string[] args)
        {

            //Write a mulitplication table for a number inputted by the user


            //User input
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            //Loop the number of times based on the number user inputted
            for (int i = 1; i <= number; i++)
            {
                //Placeholders for the three following numbers,
                //{0} is a placeholder for i and so on
                Console.WriteLine("{0} x {1} = {2}", i, number, i * number);
            };

            Console.ReadLine();
        }
    }
}