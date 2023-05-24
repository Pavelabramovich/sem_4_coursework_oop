using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOpp;

public class FlowersModel
{
    private FlowersDb _db;
    private OrdersDb _ordersDb;

    public FlowersModel()
    {
        _db = FlowersDb.Instance;
        _ordersDb = OrdersDb.Instance;
    }

    public IEnumerable<Flower> Flowers => _db.Flowers;

    public void AddOrder(string login, string productName, int count, string cardNumber)
    {
        _ordersDb.Add(new Order { CustomerLogin = login, ProductName = productName, Count = count, CardNumber = cardNumber });
    }
}
