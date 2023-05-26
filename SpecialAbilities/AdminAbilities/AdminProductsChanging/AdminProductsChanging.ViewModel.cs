using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CourseProjectOpp;

public class AdminProductsChangingViewModel : SwitchebleViewModel
{

    public ICommand CancelCommand => new DelegateCommand(o =>
    {
        SwitchToPage<SpecialAbilitiesViewModel>();
    });
}
