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



public class MainWindowViewModel : ViewModelBase
{
    private object _currentViewModel;

    public MainWindowViewModel()
    {
        _messenger = Messenger.Instance;
        _messenger.MessageValueChanged += OnMessengerValueChanged;

        _currentViewModel = new LoginPageViewModel();
    }

    public object CurrentViewModel
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

    private void OnMessengerValueChanged(object sender, Messenger.MessageValueChangedEventArgs e)
    {
        if (e.PropertyName == "CurrentViewModel" && e.NewValue is ViewModelBase)
        {
            CurrentViewModel = e.NewValue;
        }
    }
}
