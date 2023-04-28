using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOpp;

public class MainPageViewModel : BaseViewModel//, IViewModel
{




    private string? _selectedUser;
    private UserDb _db;

    public MainPageViewModel(string? userName)
    {
        _selectedUser = userName;
        _db = UserDb.Instance;
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

    public string SelectedLogin
    {
        get
        {
            var login = _db.GetName(_selectedUser) ?? "no users";
            return login ?? "null login";
        }
    }
}
