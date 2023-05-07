using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOpp;

public class SwitchebleViewModel : BaseViewModel
{
    protected void UpdatePage(BaseViewModel otherPage)
    {
        _messenger.RaiseMessageValueChanged(new UpdateViewModelMessage(otherPage));
    }

    protected void SwitchToPage<T>() where T : BaseViewModel
    {
        _messenger.RaiseMessageValueChanged(new SwitchViewModelMessage(typeof(T)));
    }



}
