using System;
using System.Linq;

namespace _04.SymbolinMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int rows = size;
            int cols = size;

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string symbols = Console.ReadLine();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = symbols[col];
                }
            }

            char symbolToFind = char.Parse(Console.ReadLine());

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row, col] == symbolToFind)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{symbolToFind} does not occur in the matrix");
        }
    }
}
