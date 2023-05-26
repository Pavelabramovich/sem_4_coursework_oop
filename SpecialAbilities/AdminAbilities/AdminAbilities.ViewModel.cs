using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CourseProjectOpp;

public class AdminAbilitiesViewModel : BaseAbilitiesViewModel
{
    public AdminAbilitiesViewModel(string login) : 
        base(login)
    { }

    public override ICommand ChangeUserCommand => new DelegateCommand(o =>
    {
        UpdatePage(new ChangeUsersViewModel(_login));
        SwitchToPage<ChangeUsersViewModel>();
    });

    public override ICommand ChangeProductsCommand => new DelegateCommand(o =>
    {
        UpdatePage(new AdminProductsChangingViewModel());
        SwitchToPage<AdminProductsChangingViewModel>();
    });

    public override BaseViewModel CurrentWindow => null;
}
