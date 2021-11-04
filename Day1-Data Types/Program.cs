using System;
using System.Collections.Generic;
using System.IO;

namespace Day1_Data_Types
{
    class Solution
    {
        static void Main(String[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";


            // Declare second integer, double, and String variables.
            int num1;
            double num2;
            string hack;
            // Read and save an integer, double, and String to your variables.
            num1 = 12;
            num2 = 4.0;
            hack = "thank you";
            // Print the sum of both integer variables on a new line.
            Console.WriteLine(num1 + i);
            // Print the sum of the double variables on a new line.
            //"{0:F2}" - shows decimal of the total value F2 == 2 decimals.
            Console.WriteLine("{0:F2}", num2 + d);
            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine($"{s}{hack}");
            Console.Read();
        }
    }
}