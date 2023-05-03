using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOpp;



public class WindowViewModel : BaseViewModel
{
    private BaseViewModel _currentViewModel;

    public WindowViewModel()
    {
        _messenger.MessageValueChanged += OnMessengerValueChanged;

        _currentViewModel = new MainViewModel();
    }

    public BaseViewModel CurrentViewModel
    {
        get => _currentViewModel;
        set
        {
            if (_currentViewModel == value)
                return;

            _currentViewModel = value;
            OnPropertyChanged();
        }
    }

    private void OnMessengerValueChanged(object? sender, Messenger.MessageValueChangedEventArgs e)
    {
        if (e.PropertyName == "CurrentViewModel" && e.NewValue is BaseViewModel newViewModel)
        {
            CurrentViewModel = newViewModel;
        }
    }
}
