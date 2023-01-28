using System;
using System.Linq;

namespace _04.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = sizes[0];
            int cols = sizes[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] elements = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);


                if (isValidCommand(rows, cols, tokens))
                {
                    string tempValue = matrix[int.Parse(tokens[1]), int.Parse(tokens[2])];
                    matrix[int.Parse(tokens[1]), int.Parse(tokens[2])] = matrix[int.Parse(tokens[3]), int.Parse(tokens[4])];
                    matrix[int.Parse(tokens[3]), int.Parse(tokens[4])] = tempValue;

                    PrintMatrix(rows, cols, matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }

        private static void PrintMatrix(int rows, int cols, string[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }

                Console.WriteLine();
            }
        }

        private static bool isValidCommand(int rows, int cols, string[] tokens)
        {
            return
                tokens[0] == "swap" 
                && tokens.Length == 5 
                && int.Parse(tokens[1]) >= 0 && int.Parse(tokens[1]) < rows
                && int.Parse(tokens[2]) >= 0 && int.Parse(tokens[2]) < cols
                && int.Parse(tokens[3]) >= 0 && int.Parse(tokens[3]) < rows
                && int.Parse(tokens[4]) >= 0 && int.Parse(tokens[4]) < cols;
        }
    }
}
