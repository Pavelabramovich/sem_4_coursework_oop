using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOpp;

public class ProviderProductsChangingModel
{
    private SupplyDb _supplyDb;
    private ProductsDb _productsDb;

    public ProviderProductsChangingModel()
    {
        _supplyDb = SupplyDb.Instance;
        _productsDb = ProductsDb.Instance;
    }

    public IEnumerable<ProductIsProvideredPair> GetProductIsProvideredPairs(string login)
    {
        var products = _productsDb.Products.Select(f => f.Name);

        var sypplies = _supplyDb.ProductsNamesByProviderLogin(login);

        foreach (var product in products)
        {
            bool isProvidered = sypplies.Contains(product);

            yield return new ProductIsProvideredPair(product, isProvidered);
        }
    }

    public void UpdateSupplies(IEnumerable<string> provideredProducts, string login)
    {
        var supplies = _supplyDb.Supplies.Where(s => s.ProviderLogin == login);

        foreach (var supply in supplies)
        {
            _supplyDb.Remove(supply.Id);
        }

        foreach (string product in provideredProducts)
        {         
            _supplyDb.Add(new Supply() { ProviderLogin = login, ProductName = product }); 
        }
    }
}
