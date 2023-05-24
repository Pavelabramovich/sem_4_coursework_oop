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

    private Flower? _currentFlower = null;

    private string _cardNumber = string.Empty;

    private int _count = 1;
   
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

    public bool IsAnonymous
    {
        get => _login is null;
    }

    public int Count
    {
        get => _count;
        set
        {
            if (value != _count)
            {
                _count = value;
                OnPropertyChanged();
            }
        }
    }

    public int Min => 1;
    public int Max => 100; 

    public string CardNumber
    {
        get => _cardNumber;
        set
        {
            if (_cardNumber != value)
            {
                _cardNumber = value;
                OnPropertyChanged();
            }
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

    public ICommand OrderCreatingCommand => new DelegateCommand(o =>
    {
        if (IsAnonymous)
            return;

        IsCreatingOrder = true;
    });

    public ICommand CancelCommand => new DelegateCommand(o =>
    {
        Count = 1;
        IsCreatingOrder = false;
    });

    public ICommand OrderApprovalCommand => new DelegateCommand(o =>
    {
        if (_login is null)
            return;

        if (CurrentFlower is null)
            throw null;

        _model.AddOrder(_login, CurrentFlower.Name, Count, CardNumber);

        Count = 1;
        IsCreatingOrder = false;
    });
}
