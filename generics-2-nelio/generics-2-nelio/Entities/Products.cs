using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_2_nelio.Entities
{
    public sealed class Products : IComparable
    {
        public string Name { get; private set; }
        public int Price { get; private set; }

        public Products(string nome, int preco)
        {   
            Valid(nome, preco);
            Name = nome;
            Price = preco;
        }

        public void Update(string nome, int preco)
        {
            Valid(nome, preco);
            Name = nome;
            Price = preco;
        }
        private void Valid(string nome, int preco)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new ArgumentNullException("Não pode ser vazio.");
            }
            if(preco <= 0)
            {
                throw new ArgumentException("Preco não pode ser vazio.");
            }
        }
        public int CompareTo(object? obj)
        {
            if(!(obj is Products))
            {
                throw new ArgumentException("Comparer error.");
            }
            
            Products other = (Products)obj;
            return Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return $"{Name} : R$ {Price}";
        }
    }
}
