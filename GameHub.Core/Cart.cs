using System.Collections.ObjectModel;

namespace GameHub.Core;

public class Cart
{
    private List<Product> _products = new();
    public ReadOnlyCollection<Product> Products => _products.AsReadOnly();

    public static Cart Create(List<Product> products)
    {
        return new Cart
        {
            _products = products
        };
    }
}