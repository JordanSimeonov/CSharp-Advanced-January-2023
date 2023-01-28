﻿using System;
using System.Linq;

namespace _08.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            string[] cordinatesPairs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var pairaindexes in cordinatesPairs)
            {
                int[] indexes = pairaindexes
                    .Split(",", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int row = indexes[0];
                int col = indexes[1];

                Explode(row, col, matrix);
            }

            int aliveCells = 0;
            int sum = 0;

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        aliveCells++;
                        sum += matrix[row, col];
                    }
                }
            }

            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sum}");

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }

                Console.WriteLine();
            }

        }
        static void Explode(int row, int col, int[,] matrix)
            {
                int value = matrix[row, col];

                if (value > 0)
                {
                    matrix[row, col] = 0;

                    if (row > 0 && matrix[row - 1, col] > 0)
                    {
                        matrix[row - 1, col] -= value;
                    }

                    if (row < matrix.GetLength(0) && matrix[row + 1, col] > 0)
                    {
                        matrix[row + 1, col] -= value;
                    }

                    if (col > 0 && matrix[row, col - 1] > 0)
                    {
                        matrix[row, col - 1] -= value;
                    }

                    if (col < matrix.GetLength(1) && matrix[row, col + 1] > 0)
                    {
                        matrix[row, col + 1] -= value;
                    }

                    if (row > 0 && col > 0 && matrix[row - 1, col - 1] > 0)
                    {
                        matrix[row - 1, col - 1] -= value;
                    }

                    if (row < matrix.GetLength(0) - 1 && col > 0 && matrix[row + 1, col - 1] > 0)
                    {
                        matrix[row + 1, col - 1] -= value;
                    }

                    if (row > 0 && col < matrix.GetLength(1) - 1 && matrix[row - 1, col + 1] > 0)
                    {
                        matrix[row - 1, col + 1] -= value;
                    }

                    if (row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1 && matrix[row + 1, col + 1] > 0)
                    {
                        matrix[row + 1, col + 1] -= value;
                    }
                }
            }
    }
}
