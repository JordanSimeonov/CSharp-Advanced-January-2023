using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string parentheses = Console.ReadLine();

            Stack<char> occur = new Stack<char>();

            bool isBalanced = true;

            if (parentheses.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }

            foreach (char parenthese in parentheses)
            {
                if (parenthese == '(' || parenthese == '{' || parenthese == '[')
                {
                    occur.Push(parenthese);
                }
                else if (parenthese == ')' || parenthese == '}' || parenthese == ']')
                {
                    if (parenthese == ')' && occur.Peek() == '(')
                    {
                        occur.Pop();
                    }
                    else if (parenthese == '}' && occur.Peek() == '{')
                    {
                        occur.Pop();
                    }
                    else if (parenthese == ']' && occur.Peek() == '[')
                    {
                        occur.Pop();
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        isBalanced = false;
                        break;
                    }
                }
            }
            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
        }
    }
}
