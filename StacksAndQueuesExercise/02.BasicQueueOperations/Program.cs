using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] elementsToEnqueue = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> numbers = new Queue<int>();

            int numbersToEnqueue = tokens[0];
            int numbersToDequeue = tokens[1];
            int elementToLookFor = tokens[2];

            for (int i = 0; i < numbersToEnqueue; i++)
            {
                numbers.Enqueue(elementsToEnqueue[i]);
            }

            for (int i = 0; i < numbersToDequeue; i++)
            {
                numbers.Dequeue();
            }

            if (numbers.Contains(elementToLookFor))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (!numbers.Any())
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(numbers.Min());
                }
            }
        }
    }
}
