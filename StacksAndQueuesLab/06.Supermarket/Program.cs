using System;
using System.Collections;
using System.Collections.Generic;

namespace _06.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> customers = new Queue<string>();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                if (input == "Paid")
                {
                    for (int i = 0; i < customers.Count; i++)
                    {
                        Console.WriteLine(customers.Dequeue());
                        i--;
                    }
                }
                else
                {
                    string customerName = input;

                    customers.Enqueue(customerName);
                }
            }

            Console.WriteLine($"{customers.Count} people remaining.");
        }
    }
}
