using Generics.Services;
using System;
using System.Collections.Generic;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintService<string> service = new PrintService<string>();
            Console.Write("How many values: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string value = Console.ReadLine();
                service.AddValue(value);
            }
            service.Print();
            Console.WriteLine($"First: {service.First()}");
        }
    }
}
