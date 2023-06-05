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

    public override string AvatarPath => _model.GetAvatarPath(_login);


    public string Login => _login;

    public ICommand ToProductCommand(ProductType productType) => new DelegateCommand(o =>
    {
        UpdatePage(new ProductsViewModel(_login, productType));
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

    public override ICommand BackCommand => DelegateCommand.DoNothing;


    public override ICommand ToFlowersCommand => ToProductCommand(ProductType.Flower);

    public override ICommand ToCandlesCommand => ToProductCommand(ProductType.Candle);

    public override ICommand ToWreathsCommand => ToProductCommand(ProductType.Wreath);

    public override ICommand ToCoffinsCommand => ToProductCommand(ProductType.Coffin);

    public override ICommand ToFencesCommand => ToProductCommand(ProductType.Fence);

    public override ICommand ToTombstonesCommand => ToProductCommand(ProductType.Tombstone);
}

