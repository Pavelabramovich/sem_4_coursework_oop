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

    public IEnumerable<TypeModel> Types
    {
        get
        {
            return Products.Select(p => (p.Type, p.Discount)).Distinct().Select(p => new TypeModel(p.Item1, p.Item2));
        }
    }



    public void UpdateProduct(Product product)
    {
        _db.Update(product);
    }
}
