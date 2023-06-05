using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CourseProjectOpp;

public class AdminAbilitiesViewModel : BaseAbilitiesViewModel
{
    private AdminAbilitiesModel _model;

    public AdminAbilitiesViewModel(string login) : 
        base(login)
    {
        _model = new AdminAbilitiesModel();
    }

    public override ICommand ChangeAvatarCommand => DelegateCommand.DoNothing;

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
}
