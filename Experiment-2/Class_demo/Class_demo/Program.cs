using System;

namespace Class_demo
{
    class Akash
    {
        String name;
        int PRN;
        public Akash(string name , int PRN)
        {
            this.name = name;
            this.PRN = PRN;
        }

        public String getName()
        {
            return name;
        }

        public int getPRN()
        {
            return PRN;
        }

        public String display()
        {
            return ("Name : " + this.getName() + " PRN : " + this.getPRN());
        }
        static void Main(String[] args)
        {
            Console.WriteLine("Enter Name: ");
            String name = Console.ReadLine();

            Console.WriteLine("Enter PRN: ");
            int PRN = int.Parse(Console.ReadLine());

            Akash a = new Akash(name, PRN);
            Console.WriteLine(a.display());
        }
    }
}
