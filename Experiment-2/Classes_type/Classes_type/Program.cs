// See https://aka.ms/new-console-template for more information

using System;

namespace Classes_type
{

    public abstract class hide
    {
        public abstract void phoneNo();
    }

    sealed class sealedClass
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    public class seal : sealedClass
    {
        Console.WriteLine("Hello ");
    }
    public class Number : hide 
    {
        public override void phoneNo()
        {
            Console.WriteLine(9503965503);
        }
    }

    
    static class Info 
    {
        static String Name = "Akash";
        static String Class = "T. Y. BTech";
        static int PRN = 1910060;

        static void display()
        {
            Console.WriteLine("My Information : ");
        }

        

        static void Main(String[] args)
        {
            //Abstract Class Demonstration
            Number n = new Number();

            n.phoneNo();

            //Static Class Demonstration

            Info.display();

            Console.WriteLine("Name : {0}", Info.Name);
            Console.WriteLine("Class : {0}", Info.Class);
            Console.WriteLine("PRN : {0}", Info.PRN);

            //Sealed Class Demonstration

            sealedClass s = new sealedClass();

            int sum = s.Add(1 , 2);

            Console.WriteLine(sum);


        }
    }

}
