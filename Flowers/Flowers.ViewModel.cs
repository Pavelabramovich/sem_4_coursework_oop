using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CourseProjectOpp;

public class FlowersViewModel : SwitchebleViewModel
{
    private FlowersModel _model;


    public FlowersViewModel()
    {
        _model = new FlowersModel();
    }

    public IEnumerable<Flower> Flowers
    {
        get => _model.Flowers;
    }

    public ICommand BackCommand => new DelegateCommand(o =>
    {
        SwitchToPage<UserViewModel>();
    });
}
