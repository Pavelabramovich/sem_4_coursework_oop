using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CourseProjectOpp;

class LoginPageViewModel : INotifyPropertyChanged
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
        IsPasswordMasked = !_isPasswordUnmasked;

        _isInvalidLogin = false;
        _isInvalidPassword = false;

        _db = UserDb.Instance;
    }

    public string Login
    {
        get => _login;
        set
        {
            if (value != _login)
            {
                _login = value;
                OnPropertyChanged("Login");

                ClearInvalidWarnings();
            }
        }
    }

    public SecureString SecurePassword 
    {
        get => _securePassword;
        set
        {
            if (value != _securePassword)
            {
                _securePassword = value;
                OnPropertyChanged("SecurePassword");

                ClearInvalidWarnings();
            }
        }
    }
    public string UnsecurePassword
    {
        get => _unsecurePassword;
        set
        {
            if (value != _unsecurePassword)
            {
                _unsecurePassword = value;
                OnPropertyChanged("UnsecurePassword");

                ClearInvalidWarnings();
            }
        }  
    }

    public bool IsPasswordUnmasked
    {
        get => _isPasswordUnmasked;
        set
        {
            if (value != _isPasswordUnmasked)
            {
                _isPasswordUnmasked = value;
                IsPasswordMasked = !value;

                if (value)
                {
                    UnsecurePassword = SecurePassword.ToUnsecureString();
                }
                else
                {
                    SecurePassword = UnsecurePassword.ToSecureString();
                }

                OnPropertyChanged("IsPasswordUnmasked");
                OnPropertyChanged("IsPasswordMasked");
            }
        }
    }
    public bool IsPasswordMasked { get; set; } 

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
        _isInvalidLogin = false;
        _isInvalidPassword = false;

        OnPropertyChanged("InvalidLoginWarning");
        OnPropertyChanged("InvalidPasswordWarning");
    }


    public event PropertyChangedEventHandler? PropertyChanged;
    public void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        if (string.IsNullOrEmpty(propertyName))   
            return;
        
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}


