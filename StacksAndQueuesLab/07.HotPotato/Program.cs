using System;
using System.Collections.Generic;

namespace _07.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int numpasses = int.Parse(Console.ReadLine());

            Queue<string> kids = new Queue<string>(names);

            while (kids.Count > 1)
            {
                for (int i = 1; i < numpasses; i++)
                {
                    string currentKid = kids.Dequeue();
                    kids.Enqueue(currentKid);
                }
                
                Console.WriteLine($"Removed {kids.Dequeue()}");
            }

            Console.WriteLine($"Last is {String.Join("", kids)}");
        }
    }
}
