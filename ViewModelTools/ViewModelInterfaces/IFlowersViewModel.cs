using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CourseProjectOpp;

public interface IFlowersViewModel
{
    public IEnumerable<Flower> Flowers { get; }

    public ICommand BackCommand { get; }
}
