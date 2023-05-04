using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOpp;

public class SwitchebleViewModel : BaseViewModel
{
    protected void SwitchToPage(BaseViewModel otherPage)
    {
        _messenger.RaiseMessageValueChanged("CurrentViewModel", otherPage);
    }
}
