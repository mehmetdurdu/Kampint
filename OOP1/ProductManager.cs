using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + "eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }

      /*  public int Topla(int sayi1, int sayi2) Örnekleme için kullanıldı.
        {
            return sayi1 + sayi2; Return dönüş değerini kullanabliriz.
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);  Ekran çıktısı başka işlemlerde kullanılmaz.
        } */
    }
}
