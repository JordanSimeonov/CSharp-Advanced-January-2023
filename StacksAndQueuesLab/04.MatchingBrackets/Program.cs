using System;
using System.Collections.Generic;

namespace _04.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            //1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5

            Stack<int> openBracketIndex = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    openBracketIndex.Push(i);
                }

                if (expression[i] == ')')
                {
                    int openBracket = openBracketIndex.Pop();

                    for (int j = openBracket; j <= i; j++)
                    {
                        Console.Write(expression[j]);
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
