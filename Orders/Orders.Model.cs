using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOpp;

public class OrdersModel
{
    private OrdersDb _ordersDb;
    private UserDb _userDb;
    
    public OrdersModel()
    {
        _ordersDb = OrdersDb.Instance;
        _userDb = UserDb.Instance;
    }

    public IEnumerable<Order> Orders => _ordersDb.Orders;

    public IEnumerable<Order> GetOrdersByProductName(string productName)
    {
        return _ordersDb.GetOrsersByProductName(productName);
    }

    public IEnumerable<Order> GetOrdersByLogin(string login)
    {
        return _ordersDb.GetOrdersByLogin(login);
    }

    public int GetUserRole(string login)
    {
        return _userDb.Contains(login) ? 1 : 0;
    }
}
