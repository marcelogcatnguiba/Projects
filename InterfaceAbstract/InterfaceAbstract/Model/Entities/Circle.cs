using System;
using System.Globalization;
using InterfaceAbstract.Model.Enums;

namespace InterfaceAbstract.Model.Entities
{
    class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public Circle(Color color, double radius)
            :base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * (Math.Pow(Radius, 2));
        }

        public override string ToString()
        {
            return $"Circle color:{Color} with radius {Radius} have area equals {Area().ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}
