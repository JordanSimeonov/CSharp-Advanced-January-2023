using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>(numbers);

            string input;

            while ((input = Console.ReadLine().ToLower()) != "end")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];

                if (command == "add")
                {
                    int firstElementToAdd = int.Parse(cmdArgs[1]);
                    int secondElementToAdd = int.Parse(cmdArgs[2]);

                    stack.Push(firstElementToAdd);
                    stack.Push(secondElementToAdd);
                }
                else if (command == "remove")
                {
                    int numOfElementsToRemove = int.Parse(cmdArgs[1]);

                    for (int i = 0; i < numOfElementsToRemove; i++)
                    {
                        if (stack.Count >= numOfElementsToRemove)
                        {
                            stack.Pop();
                        }
                    }
                }
            }

            int sum = 0;
            while (stack.Count != 0)
            {
                sum += stack.Pop();
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
