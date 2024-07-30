using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }


        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }




        // void hakkında: void diye belirttiğin metotların yaptığı işlem sonucuda ne olduğuna dair bilgiye ihtiyacın yok.Sonuçta çıkan değere ihtiyacın yok.
    }
}
