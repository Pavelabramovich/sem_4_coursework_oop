using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CourseProjectOpp;

public partial class MainViewModel : SwitchebleViewModel
{
    private BaseStrategy _strategy;

    public MainViewModel()
    {
        var model = new MainModel();
        _strategy = new AnonymousStrategy(model);
    }
    public MainViewModel(string login)
    {
        var model = new MainModel();
        _strategy = new UserStrategy(model, login);
    }

    public string UserName
    {
        get => _strategy.UserName;
    }

    public bool IsAuthorized => _strategy is AuthorizedStrategy;
    public bool IsAnonimus => _strategy is AnonymousStrategy;

    public ICommand AuthorizationCommand => _strategy.AuthorizationCommand;

    public ICommand ToFlowersCommand => _strategy.ToFlowersCommand;
}
