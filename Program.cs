using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial1910060
{
    class Program
    {
        static void Main(string[] args)
        {

            int i , num , fact = 1;
            Console.WriteLine("Enter number : ");

            num = int.Parse(Console.ReadLine());

            for(i = 2; i<= num; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine("Factorial "+ num + " : "+ fact);


            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
