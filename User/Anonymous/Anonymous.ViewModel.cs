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

    private ICommand ToProductCommand(ProductType productType) => new DelegateCommand(o =>
    {
        UpdatePage(new ProductsViewModel(productType));
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


    public override ICommand ToFlowersCommand => ToProductCommand(ProductType.Flower);

    public override ICommand ToCandlesCommand => ToProductCommand(ProductType.Candle);

    public override ICommand ToWreathsCommand => ToProductCommand(ProductType.Wreath);

    public override ICommand ToCoffinsCommand => ToProductCommand(ProductType.Coffin);

    public override ICommand ToFencesCommand => ToProductCommand(ProductType.Fence);

    public override ICommand ToTombstonesCommand => ToProductCommand(ProductType.Tombstone);
}
