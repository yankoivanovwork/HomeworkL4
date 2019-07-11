using System;
using System.Linq;

namespace HomeworkL4_Zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int n);
            int[] rowSum = new int[n];
            int[,] matrix = new int[n, n];

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
                    rowSum[i] += matrix[i, j];
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, rowSum));
        }
    }
}
