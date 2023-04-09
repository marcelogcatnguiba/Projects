using LinqCourse.Entities;
using System;
using System.Collections.Generic;

namespace LinqCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Product pro1 = new Product("TV", 1200);
            Product pro2 = new Product("Tesla", 3000);
            Product pro3 = new Product("PC", 1500);
            list.Add(pro1);
            list.Add(pro2);
            list.Add(pro3);

            Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
            list.Sort(comp);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

        }
    }
}
