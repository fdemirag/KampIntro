using System;
namespace Methods
{
	public class CartManager
	{
		public void Add(Product product)
		{
			Console.WriteLine("sepete eklendi"+ product.ProductName);
		}
		public void Add2(string ProductName,string Description,double ProductPrice,int StockAmount)
        {
            Console.WriteLine("sepete eklendi" + ProductName);
        }
	}
}

