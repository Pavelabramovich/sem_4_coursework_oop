using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CourseProjectOpp;

public abstract class BaseUserViewModel : SwitchebleViewModel, IUserViewModel
{
    private BaseUserModel _model;

    public BaseUserViewModel()
    { 
        _model = new BaseUserModel();
    }

    public abstract string Name { get; }
    public abstract ICommand AuthorizationCommand { get; }

    public abstract ICommand ToOrdersCommand { get; }

    public abstract ICommand ToSpecialAbilitiesCommand { get; }

    public abstract ICommand ToFlowersCommand { get; }
}