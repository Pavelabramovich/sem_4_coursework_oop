using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOpp;

public abstract class BaseViewModelMessage
{
    public string ViewModelName { get; set; }

    public BaseViewModelMessage(Type viewModelType) 
    {
        ViewModelName = viewModelType.Name;
    }
}


public class SwitchViewModelMessage : BaseViewModelMessage
{
    public SwitchViewModelMessage(Type viewModelType) :
        base(viewModelType)
    { }
}
public class SwitchViewModelMessage<T> : SwitchViewModelMessage where T : BaseViewModel
{ 
    public SwitchViewModelMessage() :
        base(typeof(T))
    { }
}

public class UpdateViewModelMessage : BaseViewModelMessage
{
    public BaseViewModel ViewModel { get; set; }

    public UpdateViewModelMessage(BaseViewModel viewModel) :
        base(viewModel.GetType())
    {
        ViewModel = viewModel;
    }
}


