using System;
using System.Collections.Generic;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = string.Empty;
            Stack<string> changes = new Stack<string>();

            int numOfOperations = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfOperations; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];

                if (command == "1")
                {
                    changes.Push(text);
                    text += tokens[1];
                }
                else if (command == "2")
                {
                    changes.Push(text);
                    int count = int.Parse(tokens[1]);
                    text = text.Remove(text.Length - count);
                }
                else if (command == "3")
                {
                    int index = int.Parse(tokens[1]) - 1;
                    Console.WriteLine(text[index]);
                }
                else if (command == "4")
                {
                    text = changes.Pop();
                }
            }
        }
    }
}
