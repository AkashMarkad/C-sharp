using System;

namespace Factorial
{
    class Program
    {
        static void Main(String[] args)
        {
            int i, num, fact = 1;
            Console.WriteLine("Enter number : ");

            num = int.Parse(Console.ReadLine());

            for (i = 2; i <= num; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine("Factorial " + num + " : " + fact);


            Console.ReadKey();
        }
    }
}