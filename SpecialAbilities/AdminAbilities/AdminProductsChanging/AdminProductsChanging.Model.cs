using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOpp;

public class AdminProductsChangingModel
{
    private ProductsDb _db;

    public AdminProductsChangingModel()
    {
        _db = ProductsDb.Instance;
    }

    public IEnumerable<Product> Products => _db.Products;

    public void UpdateProduct(Product product)
    {
        _db.Update(product);
    }
}
