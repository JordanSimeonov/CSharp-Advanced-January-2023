using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> queue = new Queue<string>(songs);

            while (queue.Any())
            {
                string[] tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];

                if (command == "Play")
                {
                    if (queue.Any())
                    {
                        queue.Dequeue();
                    }
                }
                else if (command == "Add")
                {
                    string songToAdd = String.Join(" ", tokens.Skip(1));

                    if (!queue.Contains(songToAdd))
                    {
                        queue.Enqueue(songToAdd);
                    }
                    else
                    {
                        Console.WriteLine($"{songToAdd} is already contained!");
                    }
                }
                else if (command == "Show")
                {
                    if (queue.Any())
                    {
                        Console.WriteLine(String.Join(", ", queue));
                    }
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
