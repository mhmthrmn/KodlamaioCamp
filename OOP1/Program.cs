using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitInStock = 5, ProductName = "kalem",UnitPrice = 35 };

            //pascalcase //camelcase
            //case sensitive
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            // void nedir farkı
            productManager.Topla2(3,6);

            int toplamSonuc = productManager.Topla(3, 6);
            Console.WriteLine(toplamSonuc*2);


            //int double bool ... değer tip
            //diziler,class,abtract class interface ... referans tip
            //ref out
        }
    }
}
