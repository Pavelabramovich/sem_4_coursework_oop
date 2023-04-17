using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CourseProjectOpp;

class LoginPageViewModel : ViewModelBase //, IViewModel
{
    private string _login;

    private string _unsecurePassword;
    private SecureString _securePassword;

    private bool _isPasswordUnmasked;

    private bool _isInvalidLogin;
    private bool _isInvalidPassword;

    private const string INVALID_LOGIN_WARNING = "Invalid login";
    private const string INVALID_PASSWORD_WARNING = "Invalid password";


    private UserDb _db;


    public LoginPageViewModel()
    {
        _login = string.Empty;

        _unsecurePassword = string.Empty;
        _securePassword = new SecureString();

        _isPasswordUnmasked = false;

        _isInvalidLogin = false;
        _isInvalidPassword = false;

        _db = UserDb.Instance;


        _nextCommand = new DelegateCommand(OnNextCommand, CanNextCommand);
    }



    public string Login
    {
        get => _login;
        set
        {
            if (value == _login)
                return;

            _login = value;
            OnPropertyChanged();

            ClearInvalidWarnings();
        }
    }

    public SecureString SecurePassword 
    {
        get => _securePassword;
        set
        {
            if (value == _securePassword)
                return;

            _securePassword = value;
            OnPropertyChanged();

            ClearInvalidWarnings();
        }
    }
    public string UnsecurePassword
    {
        get => _unsecurePassword;
        set
        {
            if (value == _unsecurePassword)
                return;

            _unsecurePassword = value;
            OnPropertyChanged();

            ClearInvalidWarnings();
        }  
    }

    public bool IsPasswordUnmasked
    {
        get => _isPasswordUnmasked;
        set
        {
            if (value == _isPasswordUnmasked)
                return;

            _isPasswordUnmasked = value;
              
            if (value)
            {
                UnsecurePassword = SecurePassword.ToUnsecureString();
            }
            else
            {
                SecurePassword = UnsecurePassword.ToSecureString();
            }

            OnPropertyChanged(nameof(IsPasswordMasked));
            OnPropertyChanged(nameof(IsPasswordUnmasked));      
        }
    }
    public bool IsPasswordMasked => !IsPasswordUnmasked;

    public string InvalidLoginWarning
    {
        get =>  _isInvalidLogin ? INVALID_LOGIN_WARNING : string.Empty;
    }
    public string InvalidPasswordWarning
    {
        get => _isInvalidPassword ? INVALID_PASSWORD_WARNING : string.Empty;
    }




    private void ClearInvalidWarnings()
    {
        if (_isInvalidLogin)
        {
            _isInvalidLogin = false;
            OnPropertyChanged(nameof(InvalidLoginWarning));
        }

        if (_isInvalidPassword)
        {
            _isInvalidPassword = false;
            OnPropertyChanged(nameof(InvalidPasswordWarning));
        }        
    }




    private readonly DelegateCommand _nextCommand;

    public ICommand NextCommand => _nextCommand;


    private bool CanNextCommand(object parameter)
    {
        return true;
    }

    public void OnNextCommand(object parameter)
    {
        _messenger.RaiseMessageValueChanged("CurrentViewModel", new MainPageViewModel(""));
    }
}


