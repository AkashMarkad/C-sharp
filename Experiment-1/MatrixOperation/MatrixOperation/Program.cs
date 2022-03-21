using System;

namespace MatrixOperation
{
    class Program
    {
        static void Main(String[] args)
        {
            int rows, cols, sum = 0;
            Console.WriteLine("Enter number of rows :  ");

            rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of column : ");

            cols = int.Parse(Console.ReadLine());

            int[,] a = new int[rows, cols];

            Console.WriteLine("Enter Elements : ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Array Elements : ");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }



            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sum = sum + a[i, j];
                }
            }

            Console.WriteLine("Addition of array element : " + sum);

            Console.WriteLine("Transpose of matrix : ");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(a[j, i] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Total element in matrix : "+ a.Length);

            // access first element from second row
            Console.WriteLine("Element at index [1, 0] : " + a[1, 0]);
        }
    }
}

