using System;

namespace HomeworkL4
{
    class Program
    {
        static void Main(string[] args)
        {
            //zad1
            int.TryParse(Console.ReadLine(), out int n);
            int[,] matrix = new int[n, n];
            int biggerNumber = int.MinValue;

            for (int fillRow = 0; fillRow < n; fillRow++)
            {
                for (int fillColumn = 0; fillColumn < n; fillColumn++)
                {
                    int.TryParse(Console.ReadLine(), out matrix[fillRow, fillColumn]);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] > biggerNumber)
                    {
                        biggerNumber = matrix[i, j];
                    }
                }
            }

            Console.WriteLine(biggerNumber);
        }
    }
}
