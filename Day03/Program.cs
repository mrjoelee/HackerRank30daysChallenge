using System;

namespace Day03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int N = Convert.ToInt32(Console.ReadLine());
            //N is odd
            if(N % 2 == 1)
            {
                Console.WriteLine("Weird");
            }
            //N is even and is between 2 and 5
            else if(N % 2 == 0 && N > 2 && N < 5)
            {
                Console.WriteLine("Not Weird");
            }
            //N is even and is between 6 and 20
            else if(N % 2 == 0 && N > 6 && N <= 20)
            {
                Console.WriteLine("Weird");
            }
            //N is even and is greater than 20
            else if(N % 2 == 0 && N > 20)
            {
                Console.WriteLine("Not Weird");
            }
            Console.Read();
        }
    }
}
