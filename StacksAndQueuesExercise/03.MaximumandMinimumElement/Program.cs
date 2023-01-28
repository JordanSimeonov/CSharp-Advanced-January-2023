using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumandMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> elements = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int command = tokens[0];

                switch (command)
                {
                    case 1:
                        elements.Push(tokens[1]);
                        break;
                    case 2:
                        elements.Pop();
                        break;
                    case 3:
                        if (elements.Any())
                        {
                            Console.WriteLine(elements.Max());
                        }
                        break;
                    case 4:
                        if (elements.Any())
                        {
                            Console.WriteLine(elements.Min());
                        }
                        break;
                }
            }

            Console.WriteLine(String.Join(", ", elements));
        }
    }
}
