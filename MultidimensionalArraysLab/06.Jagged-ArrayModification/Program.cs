using System;
using System.Linq;

namespace _06.Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                jaggedArray[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            string input = string.Empty;

            while ((input = Console.ReadLine().ToLower()) != "end")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (row < 0 || col < 0 || row >= jaggedArray.Length || col >= jaggedArray[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if (command == "add")
                    {
                        jaggedArray[row][col] += value;
                    }
                    else
                    {
                        jaggedArray[row][col] -= value;
                    }
                }
            }

            foreach (int[] array in jaggedArray)
            {
                Console.WriteLine(String.Join(" ", array));
            }
        }
    }
}
