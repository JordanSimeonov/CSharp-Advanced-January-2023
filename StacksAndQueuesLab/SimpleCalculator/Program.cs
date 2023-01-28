using System;
using System.Collections.Generic;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] expression = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Stack<string> stack = new Stack<string>();

            int result = 0;

            for (int i = expression.Length - 1; i >= 0; i--)
            {
                stack.Push(expression[i]);
            }

            result = int.Parse(stack.Pop());

            while (stack.Count != 0)
            {
                if (stack.Peek() == "+")
                {
                    stack.Pop();
                    result += int.Parse(stack.Pop());
                }
                else if (stack.Peek() == "-")
                {
                    stack.Pop();
                    result -= int.Parse(stack.Pop());
                }
            }

            Console.WriteLine(result);
        }
    }
}
