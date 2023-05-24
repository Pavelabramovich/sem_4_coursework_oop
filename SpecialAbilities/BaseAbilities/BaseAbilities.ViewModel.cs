using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CourseProjectOpp;

public abstract class BaseAbilitiesViewModel : SwitchebleViewModel
{ 
    public abstract ICommand ChangeUserCommand { get; }

    public abstract ICommand ChangeProductsCommand { get; }

    public ICommand BackCommand => new DelegateCommand(o =>
    {
        SwitchToPage<UserViewModel>();
    }); 
}
