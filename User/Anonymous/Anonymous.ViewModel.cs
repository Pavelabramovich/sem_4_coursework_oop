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

    public override ICommand AuthorizationCommand => new DelegateCommand(o =>
    {
        UpdatePage(new AuthorizationViewModel());
        SwitchToPage<AuthorizationViewModel>();
    });
}
