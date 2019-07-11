using System;
using System.Linq;

namespace HomeworkL4_Zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int n);
            int biggerRowNumber = int.MinValue;
            int biggerRow = 0;
            int[,] matrix = new int[n, n];
            string binaryNumber = string.Empty;
            Random rng = new Random(DateTime.Now.Millisecond);

            //fill matrix with random 0s and 1s
            for (int fillRow = 0; fillRow < n; fillRow++)
            {
                for (int fillColumn = 0; fillColumn < n; fillColumn++)
                {
                    matrix[fillRow, fillColumn] = rng.Next(0, 2);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                    binaryNumber += matrix[i, j];
                }
                Console.WriteLine();

                if (biggerRowNumber < Convert.ToInt32(binaryNumber, 2))
                {
                    biggerRowNumber = Convert.ToInt32(binaryNumber, 2);
                    biggerRow = i;
                }
                binaryNumber = string.Empty;
            }
            
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write(matrix[biggerRow, i] + " ");
            }
            Console.WriteLine();
        }
    }
}
