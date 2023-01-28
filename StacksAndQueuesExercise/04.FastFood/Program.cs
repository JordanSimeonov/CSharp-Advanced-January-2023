using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> ordersQueue = new Queue<int>(orders);
            Console.WriteLine(ordersQueue.Max());

            while (ordersQueue.Any())
            {
                quantity -= ordersQueue.Peek();

                if (quantity < 0)
                {
                    break;
                }

                ordersQueue.Dequeue();
            }

            if (!ordersQueue.Any())
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {String.Join(" ", ordersQueue)}");
            }
        }
    }
}
