using System;

namespace Pattern
{
    class Program
    {
        static void Main(String[] args)
        {
            int i, j, rows;

            Console.WriteLine("Enter number of rows : ");

            rows = int.Parse(Console.ReadLine());

            for(i = 0; i <= rows; i++)
            {
                for(j = 0; j < i; j++)
                {
                    Console.Write(" * ");
                }

                Console.WriteLine();
            }
        }
    }
}