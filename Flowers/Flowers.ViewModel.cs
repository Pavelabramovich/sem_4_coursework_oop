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
    private BaseViewModel _previosViewModel;

    private DelegateCommand _backCommand;


    public FlowersViewModel(BaseViewModel previosViewModel)
    {
        _model = new FlowersModel();
        _previosViewModel = previosViewModel;

        _backCommand = new DelegateCommand(OnBackCommand);
    }

    public IEnumerable<Flower> Flowers
    {
        get => _model.Flowers;
    }


    public ICommand BackCommand => _backCommand;

    public void OnBackCommand(object? parametr)
    {
        SwitchToPage(_previosViewModel);
    }
}
