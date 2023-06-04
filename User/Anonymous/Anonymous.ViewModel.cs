using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CourseProjectOpp;

public class AnonymousViewModel : BaseUserViewModel, IUserViewModel
{
    private AnonymousModel _model;

    public AnonymousViewModel()
    {
        _model = new AnonymousModel();
    }

    public override string Name => string.Empty;

    public override string AvatarPath => string.Empty;


    public override ICommand ToOrdersCommand => DelegateCommand.DoNothing;

    public override ICommand ToFlowersCommand => new DelegateCommand(o =>
    {
        UpdatePage(new ProductsViewModel(ProductType.Flower));
        SwitchToPage<ProductsViewModel>();
    });

    public override ICommand ToSpecialAbilitiesCommand => new DelegateCommand(o =>
    {

    });

    public override ICommand AuthorizationCommand => new DelegateCommand(o =>
    {
        UpdatePage(new AuthorizationViewModel());
        SwitchToPage<AuthorizationViewModel>();
    });

    public override ICommand BackCommand => DelegateCommand.DoNothing;
}
