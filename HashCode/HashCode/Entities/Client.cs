using System;
using System.Collections.Generic;
using System.Text;

namespace HashCode.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Client))
            {
                throw new ArgumentException("Obs is not a client");
            }

            Client c = obj as Client; // downcasting

            return Email.Equals(c.Email);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
