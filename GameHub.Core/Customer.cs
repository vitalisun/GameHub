using System.Collections.ObjectModel;

namespace GameHub.Core;

public class Customer
{
    private List<Purchase> _purchases { get; set; } = new();
    
    public Guid Id { get; set; }
    public string FirstName { get; protected set; }
    public string LastName { get; protected set; }
    public string Email { get; protected set; }
    public ReadOnlyCollection<Purchase> Purchases => _purchases.AsReadOnly();

    public Purchase Checkout(Cart cart)
    {
        var purchase = Purchase.Create(this, cart.Products);
        _purchases.Add(purchase);
        return purchase;
    }

    public static Customer Create(string firstName, string lastName, string email)
    {
        return new Customer
        {
            Id = Guid.NewGuid(),
            FirstName = firstName,
            LastName = lastName,
            Email = email
        };
    }
 

}