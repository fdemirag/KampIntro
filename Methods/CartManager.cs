using System;
namespace Methods
{
	public class CartManager
	{
		public void Add(Product product)
		{
			Console.WriteLine("sepete eklendi"+ product.ProductName);
		}
	}
}

