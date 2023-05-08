using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CourseProjectOpp;

public class OrdersViewModel : SwitchebleViewModel
{
    private OrdersModel _model;
    private string _login;

    public OrdersViewModel(string login)
    {
        _model = new OrdersModel();

        _login = login;
    }


    public IEnumerable<Order> Orders
    {
        get
        {
            int role = _model.GetUserRole(_login);

            if (role == 0)
                return _model.Orders;
            else
                return _model.GetOrdersByLogin(_login);
        }
    }


    public ICommand BackCommand => new DelegateCommand(o =>
    {
        SwitchToPage<UserViewModel>();
    });
}
