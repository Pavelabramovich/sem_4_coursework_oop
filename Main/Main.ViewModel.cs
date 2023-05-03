using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOpp;

public class MainViewModel : BaseViewModel
{
    private string? _selectedUser;
    private MainModel _model;

    public MainViewModel(string? userName)
    {
        _selectedUser = userName;
        _model = new MainModel();

        OnPropertyChanged("SelectedUser");
    }

    public string SelectedUser
    {
        get => _selectedUser ?? string.Empty;
        set
        {
            if (value != _selectedUser)
            {
                _selectedUser = 1 + value;
                OnPropertyChanged("SelectedUser");
            }
        }
    }
}
