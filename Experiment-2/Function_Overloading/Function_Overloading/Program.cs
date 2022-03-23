using System;

namespace Function_Overloading
{
    public class Overloading
    {
        public int sum(int a , int b)
        {
            return a + b;
        }

        public int sum(int a , int b , int c)
        {
            return a + b + c;
        }
        static void Main(String[] args)
        {
            Overloading obj = new Overloading();

           
            int sum1 = obj.sum(1, 2);
            Console.WriteLine("Sum of 2 integer value : "+ sum1);
            int sum2 = obj.sum(1, 2 , 3);
            Console.WriteLine("Sum of 3 integer value : " + sum2);
        }
    }
}
