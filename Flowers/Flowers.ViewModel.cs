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

    private string? _login;

    private bool _isCreatingOrder;

    private Flower _currentFlower = null;
   
    public FlowersViewModel()
    {
        _model = new FlowersModel();

        _login = null;

        CurrentFlower = null;

        _isCreatingOrder = false;
    }
    public FlowersViewModel(string login)
    {
        _model = new FlowersModel();

        _login = login;

        CurrentFlower = null;

        _isCreatingOrder = false;
    }


    public Flower? CurrentFlower
    {
        get => _currentFlower;
        set
        {
            if (_currentFlower != value)
            {
                _currentFlower = value;
                OnPropertyChanged();

                IsCreatingOrder = false;
            }
        }
    }

    public bool IsCreatingOrder
    {
        get => _isCreatingOrder;
        set
        {
            if (_isCreatingOrder == value) 
                return;

            _isCreatingOrder = value;
            OnPropertyChanged();
        }
    }

    public IEnumerable<Flower> Flowers
    {
        get => _model.Flowers;
    }

    public ICommand BackCommand => new DelegateCommand(o =>
    {
        if (!IsCreatingOrder)
            SwitchToPage<UserViewModel>();
    });

    public ICommand TestCommand => new DelegateCommand(o =>
    {
        IsCreatingOrder = true;

        //UpdatePage(new UserViewModel(CurrentFlower?.Name ?? "name1"));
        //SwitchToPage<UserViewModel>();
    });
}
