using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CourseProjectOpp;

public class AdminAbilitiesViewModel : BaseAbilitiesViewModel
{
    public override ICommand ChangeUserCommand => new DelegateCommand(o =>
    {

    });

    public override ICommand ChangeProductsCommand => new DelegateCommand(o =>
    {

    });
}
