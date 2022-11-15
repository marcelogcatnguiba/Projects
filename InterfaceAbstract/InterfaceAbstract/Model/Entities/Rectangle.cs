using System.Globalization;
using InterfaceAbstract.Model.Enums;
namespace InterfaceAbstract.Model.Entities
{
    internal class Rectangle : AbstractShape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(Color color, int width, int height)
            :base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return $"Rectangle color {Color} with WIdth {Width} and Height {Height} have area equals {Area().ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}
