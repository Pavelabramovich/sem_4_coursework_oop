using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOpp;

public class WindowMessage
{
    public Type WindowType { get; init; }

    public bool Visibility { get; init; }


    public WindowMessage(Type targetViewModelType, bool visibility) 
    { 
        WindowType = targetViewModelType;
        Visibility = visibility;
    }
}

public class WindowMessage<T> : WindowMessage where T : BaseViewModel
{
    public WindowMessage(bool visibility) :
        base(typeof(T), visibility)
    { }
}

