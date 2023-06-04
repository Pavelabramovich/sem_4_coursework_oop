using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CourseProjectOpp;

public class ProductIsProvideredPair : ObservableObject
{ 
    public ProductIsProvideredPair(string productName, bool isProvidered)
    {
        ProductName = productName;
        _isProvidered = isProvidered;
    }

    public string ProductName { get; init; }

    private bool _isProvidered;

    public bool IsProvidered
    {
        get => _isProvidered;
        set
        {
            _isProvidered = value;
            OnPropertyChanged();
        }
    }
}


public class ProviderProductsChangingViewModel : SwitchebleViewModel
{
    private string _login;

    private ProviderProductsChangingModel _model;


    public ObservableCollection<ProductIsProvideredPair> Products { get; set; }


    public ProviderProductsChangingViewModel(string login)
    {
        _login = login;
        _model = new ProviderProductsChangingModel();

        Products = new(_model.GetProductIsProvideredPairs(login));
    }





    public ICommand SaveChangesCommand => new DelegateCommand(o =>
    {
        _model.UpdateSupplies(Products.Where(p => p.IsProvidered).Select(p => p.ProductName), _login);

        SwitchToPage<SpecialAbilitiesViewModel>();
    });


    public ICommand CancelCommand => new DelegateCommand(o =>
    {
        SwitchToPage<SpecialAbilitiesViewModel>();
    });

    public override ICommand BackCommand => CancelCommand;
} 
