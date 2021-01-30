using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitsInStock = 3;

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 5,
                ProductName = "kalem",
                UnitsInStock = 5,
                UnitPrice = 35
            };

            //PascalCase //camelCase
            //case sensitive
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }


        //int, double, bool --- değer tip
        //arrays, classes, abstract classes --- referans tip
        //ref out

    }
}
