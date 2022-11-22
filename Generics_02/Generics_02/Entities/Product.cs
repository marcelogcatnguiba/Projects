using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_02.Entities
{
    internal class Product : IComparable
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public Product()
        {
        }
        public Product(string name, double value)
        {
            Name = name;
            Value = value;
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Product))
            {
                throw new ArgumentException("Obj is not a product");
            }
            Product p = obj as Product;

            return Value.CompareTo(p.Value);
        }

        public override string ToString()
        {
            return $"{Name}, {Value}";
        }
    }
}
