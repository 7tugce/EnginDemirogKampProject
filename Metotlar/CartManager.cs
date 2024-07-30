using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class CartManager
    {
        public void Add(Product product)// parametre
        {
            Console.WriteLine("Sepete eklendi: "+ product.Name);
        }

        public void Add2(string name, string description, double price)
        {
            Console.WriteLine("Sepete eklendi: " + name);
        }
    }
}
