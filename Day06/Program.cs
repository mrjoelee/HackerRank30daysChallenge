using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    //Hackerrank Day 06 - sepearting the string into prime and odd
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a length: ");
            var N = int.Parse(Console.ReadLine());

            for (var i = 0; i < N; i++)
            {
                Console.WriteLine("Please input a word: ");
                var str = Console.ReadLine();

                //loops around and see which index of the string is an even and displays those letter
                Console.WriteLine("Even Index Letter \n");
                for (var j = 0; j < str.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write(str[j]);
                    }
                }


                Console.WriteLine();

                Console.WriteLine("----------------------------");

                //loops around and see which index of the string is an odd and displays those letter
                Console.WriteLine("Odd Index Letter \n");
                for (var j = 0; j < str.Length; j++)
                {
                    if (j % 2 != 0)
                    {
                        Console.Write(str[j]);
                    }
                }

                
                Console.ReadLine();
            }
        }
    }
}
