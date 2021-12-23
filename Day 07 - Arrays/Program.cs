using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_07___Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySize = Convert.ToInt32(Console.ReadLine().Trim());

            List<char> arr = Console.ReadLine().TrimEnd().ToList();/*.Select(joe => joe).ToList();*/

            for (int index = arraySize - 1; index > -1; index--)
            {
                //Console.WriteLine(index.ToString());
                Console.Write($"{arr[index]} ");

            }
            Console.ReadLine();


        }

        //static void Main(string[] args)
        //{
        //    //Given an Array, A, of N integers, print A's elements in reverse order as a single line of
        //    //space-separated numbers

        //    //size of the array
        //    int n = Convert.ToInt32(Console.ReadLine());

        //    //using the split method to put a space between
        //    string[] arraytemp = Console.ReadLine().Split('');

        //    //the ConverAll method converts an array of one type to an array of another type.
        //    int[] array = Array.ConvertAll(arraytemp, Int32.Parse);

        //    //loops in the elemnt of [i] and 
        //    for (var i = n - 1; i > -1; i--)
        //    {
        //        Console.Write($"{array[i]} ");
        //    }

        //    Console.Read();
        //}
    }
}
