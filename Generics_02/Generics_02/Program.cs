using Generics_02.Entities;
using Generics_02.Services;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Generics_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Product> products = new List<Product>();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(',');
                string name = s[0];
                double value = double.Parse(s[1], CultureInfo.InvariantCulture);

                products.Add(new Product(name, value));
            }

            CalculadoraService calculadoraService = new CalculadoraService();
            Product max = calculadoraService.Max(products);

            Console.Write($"Max : {max}");
        }
    }
}
