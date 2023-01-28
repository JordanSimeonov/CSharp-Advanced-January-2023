using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothesInTheBox = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rackCapacity = int.Parse(Console.ReadLine());

            Stack<int> clothes = new Stack<int>(clothesInTheBox);

            int racksCount = 1;
            int clothesSum = 0;

            while (clothes.Any())
            {

                clothesSum += clothes.Peek();

                if (rackCapacity < clothesSum)
                {
                    clothesSum = 0;
                    racksCount++;
                    continue;
                }

                clothes.Pop();
            }

            Console.WriteLine(racksCount);
        }
    }
}
