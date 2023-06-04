using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CourseProjectOpp;

public abstract class BaseAbilitiesViewModel : SwitchebleViewModel
{
    protected string _login;

    public BaseAbilitiesViewModel(string login)
    {
        _login = login;
    }


    public abstract BaseViewModel CurrentWindow { get; }


    public abstract ICommand ChangeUserCommand { get; }

    public abstract ICommand ChangeProductsCommand { get; }

    public override ICommand BackCommand => new DelegateCommand(o =>
    {
        SwitchToPage<UserViewModel>();
    });
}
