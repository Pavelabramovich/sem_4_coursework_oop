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

    public SpecialAbilitiesViewModel(string login) 
    {
        _login = login;
        
        _model = new SpecialAbilitiesModel();

        _userRole = _model.GetUserRole(login);


        _strategy = _userRole switch
        {
            UserRole.Customer => new CustomerAbilitiesViewModel(_login),
            UserRole.Provider => new ProviderAbilitiesViewModel(_login),
            UserRole.Admin => new AdminAbilitiesViewModel(_login),
            _ => throw new ArgumentException("Unknown role"),
        };  
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

    public BaseViewModel CurrentWindow => _strategy.CurrentWindow;

    public ICommand ChangeUserCommand => _strategy.ChangeUserCommand;

    public ICommand ChangeProductsCommand => _strategy.ChangeProductsCommand;

    public ICommand BackCommand => _strategy.BackCommand;



    //private void OnMessengerValueChanged(object? sender, Messenger.MessageValueChangedEventArgs e)
    //{
    //    if (e.Message is WindowMessage windowMessage && windowMessage.TargetViewModelType == this.GetType())
    //    {
            
    //    }
    //}

}
