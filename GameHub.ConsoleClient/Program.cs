
using GameHub.Core;

public class Program
{
    public static void Main(string[] args)
    {
        var products = new List<Product>
        {
            new Product("Resident evil", 10.99m, 1),
            new Product("GTA V", 20.99m, 1),
            new Product("Fifa 19", 30.99m, 1),
            new Product("The Witcher 3", 40.99m, 1),
        };

        var cart = Cart.Create(products);
        var customer = Customer.Create("John", "Doe", "jdoe@gmail.com");
        var purchase = customer.Checkout(cart);

        Console.WriteLine($"Purchase: {purchase.Id}");
        Console.WriteLine($"Customer: {purchase.Customer.FirstName} {purchase.Customer.LastName}");

        foreach (var product in purchase.Products)
        {
            Console.WriteLine($"Product: {product.Name} - {product.Price}");
        }
    }
}