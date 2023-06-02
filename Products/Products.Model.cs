using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOpp;

public class ProductsModel
{
    private ProductsDb _productsDb;
    private OrdersDb _ordersDb;

    public ProductsModel()
    {
        _productsDb = ProductsDb.Instance;
        _ordersDb = OrdersDb.Instance;
    }

    public IEnumerable<Product> Products => _productsDb.Products;

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

    public void AddOrder(string login, string productName, int count, string cardNumber)
    {
        _ordersDb.Add(new Order { CustomerLogin = login, ProductName = productName, Count = count, CardNumber = cardNumber });
    }
}
