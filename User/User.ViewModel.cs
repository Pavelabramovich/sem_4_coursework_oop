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
        _strategy = new CustomerViewModel(login);
    }

    public string UserName
    {
        get => _strategy.Name;
    }

    public bool IsAuthorized => _strategy is CustomerViewModel;
    public bool IsAnonymous => _strategy is AnonymousViewModel;

    public ICommand AuthorizationCommand => _strategy.AuthorizationCommand;

    public ICommand ToOrdersCommand => _strategy.ToOrdersCommand;

    public ICommand ToFlowersCommand => _strategy.ToFlowersCommand;
}
