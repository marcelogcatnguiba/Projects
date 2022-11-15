using InterfaceAbstract.Model.Entities;
using InterfaceAbstract.Model.Enums;
using System;

namespace InterfaceAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle(Color.Black, 2);
            IShape rectangle = new Rectangle(Color.Red, 2, 3);

            Console.WriteLine(circle);
            Console.WriteLine(rectangle);
        }
    }
}
