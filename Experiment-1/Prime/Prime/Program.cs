using System;


namespace Prime
{
    class Program
    {
        static void Main(String[] args)
        {
            int num , i ;
            Boolean flag = false;

            Console.WriteLine("Enter Number you want to check prime : ");

            num = int.Parse(Console.ReadLine());

            for(i = 2; i < num/2; i++)
            {
                if(num%i==0)
                {
                    flag = true; 
                    break;
                }
                else
                {
                    flag = false;
                }
            }

            if(flag==true)
            {
                Console.WriteLine(num + " is not prime Number ");
            }
            else
            {
                Console.WriteLine(num + " is prime Number ");
            }
        }
    }
}