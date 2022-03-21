using System;

namespace Addition
{
    class Program
    {
        static void Main(String[] args)
        {
            int i, j, n, sum = 0;


            Console.WriteLine("enter how many number you want to add : ");

            n = int.Parse(Console.ReadLine());

            int[] a = new int[n];

            Console.WriteLine("Enter " + n + " numbers : ");

            for (i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            for (j = 0; j < a.Length; j++)
            {
                sum = sum + a[j];
            }

            Console.WriteLine("Sum : " + sum);

            Console.ReadKey();
        }
    }
}
