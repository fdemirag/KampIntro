using System;
namespace OOP1
{
	public class product
	{
		public int Id { get; set; }
		public int CategoryId { get; set; } //foreign key
		public string ProductName { get; set; }
		public double UnitPrice { get; set; }
		public int UnitsInStock { get; set; }
	}
}

