using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product
            {
                Id=1,
                CategoryId = 1,
                ProductName="Telefon",
                UnitPrice=2000
            };
            ProductManager productManager = new ProductManager();
            productManager.Add(product);
        }
    }
}
