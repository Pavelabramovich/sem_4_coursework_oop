using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CourseProjectOpp;

public class SpecialAbilitiesViewModel : SwitchebleViewModel
{
    private BaseAbilitiesViewModel _strategy;
    private SpecialAbilitiesModel _model;

    private UserRole _userRole;

    private string _login;

    private int _discount;

    public SpecialAbilitiesViewModel(string login) 
    {
        _login = login;
        
        _model = new SpecialAbilitiesModel();

        _userRole = _model.GetUserRole(login);

        _discount = _model.GetDiscount(login);

        _strategy = _userRole switch
        {
            UserRole.Customer => new CustomerAbilitiesViewModel(_login),
            UserRole.Provider => new ProviderAbilitiesViewModel(_login),
            UserRole.Admin => new AdminAbilitiesViewModel(_login),
            _ => throw new ArgumentException("Unknown role"),
        };  

        if (_strategy is CustomerAbilitiesViewModel viewModel)
        {
            viewModel.NameChanged += OnNameChanged;
            viewModel.AvatarChanged += OnAvatarChanged;
        }
    }

    public UserRole UserRole
    {
        get => _userRole;
        set
        {
            if (value == _userRole)
                return;

            _userRole = value;
            OnPropertyChanged();
        }
    }

    public string Login => _login;

    public string Name => _model.GetName(_login);

    public int Discount
    {
        get => _discount;
        set
        {
            if (_discount != value)
            {
                _discount = value;
                OnPropertyChanged();
            }
        }
    }

    public string Color
    {
        get
        {
            var converter = new LoginToColorConverter();

            return (string)converter.Convert(_login, null, null, null);
        }
    }

    public string AvatarPath => _model.GetAvatarPath(_login);

    public ICommand ChangeAvatarCommand => _strategy.ChangeAvatarCommand;

    public ICommand ChangeUserCommand => _strategy.ChangeUserCommand;

    public ICommand ChangeProductsCommand => _strategy.ChangeProductsCommand;

    public override ICommand BackCommand => _strategy.BackCommand;

    private void OnNameChanged()
    {
        OnPropertyChanged(nameof(Name));
    }

    private void OnAvatarChanged()
    {
        OnPropertyChanged(nameof(AvatarPath));
    }
}
