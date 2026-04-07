using ECommerceWebAPI.Http;
using ECommerceWebAPI.Http.Interfaces;

namespace ECommerceWebAPI.Http.Services;

public class ProductService : IProductService
{
    private readonly List<Product> _products =
    [
        new Product
        {
            Id = 1,
            Name = "Wireless Mouse",
            Category = "Electronics",
            Price = 799.00m,
            StockQuantity = 25
        },
        new Product
        {
            Id = 2,
            Name = "Mechanical Keyboard",
            Category = "Electronics",
            Price = 2499.00m,
            StockQuantity = 12
        },
        new Product
        {
            Id = 3,
            Name = "Office Chair",
            Category = "Furniture",
            Price = 6999.00m,
            StockQuantity = 5
        }
    ];

    public IEnumerable<Product> GetAll()
    {
        return _products.OrderBy(product => product.Id);
    }

    public Product? GetById(int id)
    {
        return _products.FirstOrDefault(product => product.Id == id);
    }

    public Product Create(Product product)
    {
        var newProduct = new Product
        {
            Id = _products.Count == 0 ? 1 : _products.Max(existingProduct => existingProduct.Id) + 1,
            Name = product.Name,
            Category = product.Category,
            Price = product.Price,
            StockQuantity = product.StockQuantity
        };

        _products.Add(newProduct);

        return newProduct;
    }

    public bool Update(int id, Product product)
    {
        var existingProduct = GetById(id);

        if (existingProduct is null)
        {
            return false;
        }

        existingProduct.Name = product.Name;
        existingProduct.Category = product.Category;
        existingProduct.Price = product.Price;
        existingProduct.StockQuantity = product.StockQuantity;

        return true;
    }

    public bool Delete(int id)
    {
        var existingProduct = GetById(id);

        if (existingProduct is null)
        {
            return false;
        }

        _products.Remove(existingProduct);

        return true;
    }
}
