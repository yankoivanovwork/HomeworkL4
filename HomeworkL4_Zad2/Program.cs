using System;
using System.Linq;

namespace HomeworkL4_Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int n);
            int[,] matrix = new int[n, n];
            int sum = 0;

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
                    sum += matrix[i, j];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
