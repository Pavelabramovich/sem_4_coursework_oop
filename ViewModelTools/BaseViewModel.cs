using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOpp;


public abstract class BaseViewModel : ObservableObject
{
    protected Messenger _messenger;

    public BaseViewModel()
    {
        _messenger = Messenger.Instance;
    }
}