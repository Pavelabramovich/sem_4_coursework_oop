using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOpp;

public class ProductsModel
{
    private UserDb _userDb;
    private ProductsDb _productsDb;
    private SupplyDb _supplyDb;
    private OrdersDb _ordersDb;

    public ProductsModel()
    {
        _productsDb = ProductsDb.Instance;
        _ordersDb = OrdersDb.Instance;
        _userDb = UserDb.Instance;
        _supplyDb = SupplyDb.Instance;
    }

    public IEnumerable<Product> Products => _productsDb.Products;

    public int GetDiscount(string login) => _userDb.GetDiscount(login);

    public IEnumerable<Product> GetProductsByType(ProductType type)
    {
        foreach (Product product in _productsDb.Products)
        {
            if (type.HasFlag(product.Type))
            {
                yield return product;
            }
        }
    }

    public IEnumerable<Product> GetProvideredProducts(ProductType type)
    {
        var products = GetProductsByType(type);

        var supplies = _supplyDb.Supplies;

        foreach (Product product in products)
        {
            if (supplies.Count(s => s.ProductName == product.Name) > 0)
            {
                yield return product;
            }
        }
    }

    public void AddOrder(string login, string productName, int count, string cardNumber)
    {
        _ordersDb.Add(new Order { CustomerLogin = login, ProductName = productName, Count = count, CardNumber = cardNumber });
    }
}
