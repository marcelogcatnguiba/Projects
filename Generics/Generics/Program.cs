using Generics.Services;
using System;
using System.Collections.Generic;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintService service = new PrintService();
            Console.Write("How many values: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int value = int.Parse(Console.ReadLine());
                service.AddValue(value);
            }
            service.Print();
            Console.WriteLine($"First: {service.First()}");
        }
    }
}
