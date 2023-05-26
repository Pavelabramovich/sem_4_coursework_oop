using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CourseProjectOpp;

public class ProviderAbilitiesViewModel : CustomerAbilitiesViewModel
{
    public ProviderAbilitiesViewModel(string login)
        : base(login)
    { }

    public override ICommand ChangeProductsCommand => new DelegateCommand(o =>
    {
        UpdatePage(new ProviderProductsChangingViewModel(_login));
        SwitchToPage<ProviderProductsChangingViewModel>();
    });
}
