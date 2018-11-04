using System;


namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {

            byte x, y;
            x = y = 0;
            bool isValidX = false;
            bool isValidY = false;


            while (isValidX == false)
            {
                try
                {
                    Console.WriteLine("Enter x");
                    x = Byte.Parse(Console.ReadLine());
                    isValidX = true;
                }
                catch
                {
                    Console.WriteLine("Wrong input.");

                    Console.WriteLine();
                }
            }
            Console.WriteLine();

            while (isValidY == false)
            {
                try
                {
                    Console.WriteLine("Enter y");
                    y = Byte.Parse(Console.ReadLine());
                    isValidY = true;
                }
                catch
                {
                    Console.WriteLine("Wrong input.");

                    Console.WriteLine();
                }
            }
            /*
            int[,] matrix = new int[x, y];
            

            int[] array = new int[x];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
                Console.WriteLine(array[i]);
            }
            */

            int[,] array1 = new int[x, y];
            int[,] array2 = new int[y, x];

            int rows = array1.GetUpperBound(0) + 1;
            int columns = array1.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("Enter elements of the matrix with coordinates: [" + (i + 1) + ":" + (j + 1) + "]");
                    array1[i, j] = Int32.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine("Your matrix is: ");
            Console.WriteLine();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array1[i, j] + "\t");
                }
                Console.WriteLine();

            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array2[j, i] = array1[i, j];
                }
            }

            Console.WriteLine("Transpose of a matrix: ");
            Console.WriteLine();
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(array2[i, j] + "\t");
                }
                Console.WriteLine();

            }
            Console.ReadKey();



        }
    }
}
