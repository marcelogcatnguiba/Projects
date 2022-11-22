using HashCode.Entities;
using System;
using System.Xml;

namespace HashCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client() { Name = "Marcelo", Email = "marcelogomes@gmail.com" };
            Client b = new Client() { Name = "Maria", Email = "Marcelogomes@gmail.com" };


            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

            Console.WriteLine(a.Equals(b));
        }
    }
}
