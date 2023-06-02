using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CourseProjectOpp;

public class CustomerViewModel : BaseUserViewModel, IUserViewModel
{
    private CustomerModel _model;
    private string _login;

    public CustomerViewModel(string login)
    {
        _model = new CustomerModel();
        _login = login;
    }

    public override string Name
    {
        get => _model.GetName(_login);
    }

    public override ICommand ToFlowersCommand => new DelegateCommand(o =>
    {
        UpdatePage(new ProductsViewModel(_login, ProductType.Flower));
        SwitchToPage<ProductsViewModel>();
    });

    public override ICommand ToSpecialAbilitiesCommand => new DelegateCommand(o =>
    {
        UpdatePage(new SpecialAbilitiesViewModel(_login));
        SwitchToPage<SpecialAbilitiesViewModel>();
    });

    public override ICommand ToOrdersCommand => new DelegateCommand(o =>
    {
        UpdatePage(new OrdersViewModel(_login));
        SwitchToPage<OrdersViewModel>();
    });

    public override ICommand AuthorizationCommand => new DelegateCommand(o =>
    {
        UpdatePage(new UserViewModel());
        SwitchToPage<UserViewModel>();
    });
}

