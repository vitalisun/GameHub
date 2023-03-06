using System.Collections.ObjectModel;

namespace GameHub.Core;

public class Purchase
{
    private List<Product> _products = new();
    
    public Guid Id { get; protected set; }
    public DateTime Created { get; protected set; }
    public Customer Customer { get; protected set; }
    public ReadOnlyCollection<Product> Products => _products.AsReadOnly();

    public static Purchase Create(Customer customer, ReadOnlyCollection<Product> products)
    {
        return new Purchase
        {
            Id = Guid.NewGuid(),
            Created = DateTime.Now,
            Customer = customer,
            _products = products.ToList()
        };
    }
    
}