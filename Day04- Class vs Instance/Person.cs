using System;

namespace Day04__Class_vs_Instance
{
    class Person
    {
        int age;
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an age:");
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                Person p = new Person(T);
                p.AmIOld();
                for (int j = 0; j < 3; j++)
                {
                    p.yearPasses();
                }
                p.AmIOld();
                Console.WriteLine();
            }

        }

        public Person(int initialAge)
        {
           if (initialAge >= 0)
            {
                age = initialAge;
            }
            else
            {
                Console.WriteLine("Age is not valid, setting age to 0.");
            }
        }

        public void AmIOld()
        {
            if (age < 13)
            {
                Console.WriteLine("You are young.");
            }
            else if (age >= 13 && age < 18)
            {
                Console.WriteLine("You are a teenager.");
            }
            else
            {
                Console.WriteLine("You are old.");
            }
        }

        public void yearPasses()
        {
            age = age + 1;
        }
    }
}
