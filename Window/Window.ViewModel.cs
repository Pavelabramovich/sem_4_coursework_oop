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
    private Dictionary<string, BaseViewModel> _viewModels;
    private string _currentViewModelName;

    public WindowViewModel()
    {
        _messenger.MessageValueChanged += OnMessengerValueChanged;

        _currentViewModelName = nameof(UserViewModel);
        _viewModels = new();

        _viewModels[_currentViewModelName] = new UserViewModel();
    }

    private string CurrentViewModelName
    {
        get => _currentViewModelName;
        set
        {
            // if (_currentViewModelName == value)
            //    return;

            _currentViewModelName = value;

            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
    public BaseViewModel CurrentViewModel
    {
        get => _viewModels[_currentViewModelName];
    }

    private void OnMessengerValueChanged(object? sender, Messenger.MessageValueChangedEventArgs e)
    {
        if (e.Message is BaseViewModelMessage viewModelMessage)
        {
            if (viewModelMessage is UpdateViewModelMessage updateMessage)
            {
                string viewModelName = viewModelMessage.ViewModelName;

                _viewModels[viewModelName] = updateMessage.ViewModel;
            }
            else if (viewModelMessage is SwitchViewModelMessage switchMessage)
            {
                string viewModelName = switchMessage.ViewModelName;
                CurrentViewModelName = viewModelName;
            }
        }
        else
            throw null;
    }
}
