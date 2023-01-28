using System;
using System.Linq;

namespace _02.SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sizes = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            int rows = int.Parse(sizes[0]);
            int cols = int.Parse(sizes[1]);

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = numbers[col];
                }

            }

            for (int col = 0; col < cols; col++)
            {
                int currentColSum = 0;

                for (int row = 0; row < rows; row++)
                {
                    currentColSum += matrix[row, col];
                }
                Console.WriteLine(currentColSum);
            }
        }
    }
}
