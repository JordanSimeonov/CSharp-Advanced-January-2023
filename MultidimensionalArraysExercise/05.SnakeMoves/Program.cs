using System;
using System.Linq;

namespace _05.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();

            string snake = Console.ReadLine();

            int rows = dimensions[0];
            int cols = dimensions[1];

            char[,] matrix = new char[rows, cols];

            int wordIndex = 0;

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (wordIndex == snake.Length)
                        {
                            wordIndex = 0;
                        }

                        matrix[row, col] = snake[wordIndex];

                        wordIndex++;
                    }
                }
                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        if (wordIndex == snake.Length)
                        {
                            wordIndex = 0;
                        }

                        matrix[row, col] = snake[wordIndex];

                        wordIndex++;
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }

                Console.WriteLine();
            }
        }
    }
}
