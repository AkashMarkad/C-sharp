using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            
           
            int i, j, n, sum = 0;


            Console.WriteLine("enter how many number you want to add : ");

            n = int.Parse(Console.ReadLine());

            int[] a = new int[n];

            Console.WriteLine("Enter " +n+ " numbers : ");

            for (i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            for(j = 0; j < a.Length; j++)
            {
                sum = sum + a[j];
            }

            Console.WriteLine("Sum : " + sum);

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
