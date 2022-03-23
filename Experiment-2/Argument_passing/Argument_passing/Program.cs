//ref is used to state that the parameter passed may be modified by the method.

//in is used to state that the parameter passed cannot be modified by the method.

//out is used to state that the parameter passed must be modified by the method.

using System;

namespace Argument_passing
{
    public static class Argument_passing
    {

        static void SetValue(ref String str1)
        {
            //Ckeck parameter value
            if(str1 == "Akash")
            {
                Console.WriteLine("Hii "+ str1);
            }

            //Assign the new value of the parameter
            str1 = "Hello " + str1;
        }


        //Method in which out parameter is passed and this method returns the value of the passed parameter
        public static void Sum(out int G)
        {
            G = 100;
            G += 1;
        }
        public static void Main()
        {
            String str = "Akash";

            // Pass as a reference parameter
            SetValue(ref str);

            // Display the given string
            Console.WriteLine(str);



            //Declaring variable without assigning value
            int G;

            //Pass variable G to the method using out keyword
            Sum(out G);

            //Display the value G 
            Console.WriteLine("The sum of the value is: {0}" , G);

        }
    }


}