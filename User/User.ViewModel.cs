using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CourseProjectOpp;

public class UserViewModel : SwitchebleViewModel
{
    private IUserViewModel _strategy;

    public UserViewModel()
    {
        _strategy = new AnonymousViewModel();
    }
    public UserViewModel(string login)
    {
        if (string.IsNullOrEmpty(login))
            throw new ArgumentException("Null or empty login");

        _strategy = new CustomerViewModel(login);
    }

    public string UserName
    {
        get => _strategy.Name;
    }

    public string Login
    {
        get
        {
            if (_strategy is CustomerViewModel customer)
            {
                return customer.Login;
            }
            else
                return string.Empty;
        }
        set
        {

        }
    }

    public string Color
    {
        get
        {
            var converter = new LoginToColorConverter();

            return (string)converter.Convert(Login, null, null, null);
        }
    }


    public string AvatarPath => _strategy.AvatarPath;

    public bool IsAuthorized => _strategy is CustomerViewModel;
    public bool IsAnonymous => _strategy is AnonymousViewModel;

    public ICommand AuthorizationCommand => _strategy.AuthorizationCommand;

    public ICommand ToOrdersCommand => _strategy.ToOrdersCommand;

    public ICommand ToFlowersCommand => _strategy.ToFlowersCommand;
    public ICommand ToCandlesCommand => _strategy.ToCandlesCommand;
    public ICommand ToWreathsCommand => _strategy.ToWreathsCommand;
    public ICommand ToCoffinsCommand => _strategy.ToCoffinsCommand;
    public ICommand ToFencesCommand => _strategy.ToFencesCommand;
    public ICommand ToTombstonesCommand => _strategy.ToTombstonesCommand;

    public ICommand ToSpecialAbilitiesCommand => _strategy.ToSpecialAbilitiesCommand;


    public override ICommand BackCommand => DelegateCommand.CantExecute;
}
