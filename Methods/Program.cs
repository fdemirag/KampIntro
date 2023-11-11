using Methods;

internal class Program
{
    private static void Main(string[] args)
    {

        Product product1 = new Product();
        product1.ProductName = "Elma";
        product1.ProductPrice = 80.5;
        product1.Description = "AmasyaElması";

        Product product2 = new Product();
        product2.ProductName = "Karpuz";
        product2.ProductPrice = 105.5;
        product2.Description = "Diyarbakır karpuzu";

        Product[] products = new Product[] { product1, product2 };

        foreach (var product in products)
        {
            Console.WriteLine(product.Description);

            Console.WriteLine(product.ProductName);

            Console.WriteLine(product.ProductPrice);
        }

        //metotlar
        CartManager cartManager = new CartManager();
        cartManager.Add(product1);
        cartManager.Add(product2);
        //cartManager.Add();
        //cartManager.Add();


        Console.Read();
    }
}