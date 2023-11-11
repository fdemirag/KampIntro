using System;
namespace OOP1
{
	public class ProductManager
	{
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " Eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " Güncellendi.");
        }
    }
}

