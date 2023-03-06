namespace GameHub.Core;

public class Product
{

    public Guid Id { get; protected set; }
    public string Name { get; protected set; }
    public decimal Price { get; protected set; }
    public int Quantity { get; protected set; }
    public DateTime Created { get; protected set; }
    public DateTime Modified { get; protected set; }

    public Product(string name, decimal price, int quantity)
    {
        Id = Guid.NewGuid();
        Name = name;
        Price = price;
        Quantity = quantity;
        Created = DateTime.UtcNow;
        Modified = DateTime.UtcNow;
    }
}