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
using System.Xml.Linq;

namespace CourseProjectOpp;

class AuthorizationViewModel : SwitchebleViewModel
{
    private enum AuthorizationWarningState
    {
        NoWarnings = 0,
        InvalidLogin = 1,
        InvalidPassword = 2,
    }

    private AuthorizationModel _model;


    private string _login;

    private string _unsecurePassword;
    private SecureString _securePassword;

    private bool _isPasswordUnmasked;

    private AuthorizationWarningState _warningState;

    private const string INVALID_LOGIN_WARNING = "Invalid login";
    private const string INVALID_PASSWORD_WARNING = "Invalid password";


    private readonly DelegateCommand _signInCommand;
    private readonly DelegateCommand _backCommand;


    public AuthorizationViewModel()
    {
        _model = new AuthorizationModel(UserDb.Instance);


        _login = string.Empty;

        _unsecurePassword = string.Empty;
        _securePassword = new SecureString();

        _isPasswordUnmasked = false;

        _warningState = AuthorizationWarningState.NoWarnings;

        _signInCommand = new DelegateCommand(OnSignInCommand);
        _backCommand = new DelegateCommand(OnBackCommand);
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

            WarningState = AuthorizationWarningState.NoWarnings;
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

            WarningState = AuthorizationWarningState.NoWarnings;
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

            WarningState = AuthorizationWarningState.NoWarnings;
        }
    }

    private IEnumerable<char> Password
    {
        get => IsPasswordMasked ? SecurePassword.GetCharSequance() : UnsecurePassword;
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

    private AuthorizationWarningState WarningState
    {
        get => _warningState;
        set
        {
            if (value == _warningState)
                return;

            _warningState = value;

            OnPropertyChanged(nameof(InvalidLoginWarning));
            OnPropertyChanged(nameof(InvalidPasswordWarning));
        }
    }

    public string InvalidLoginWarning
    {
        get => (WarningState == AuthorizationWarningState.InvalidLogin) ? INVALID_LOGIN_WARNING : string.Empty;
    }
    public string InvalidPasswordWarning
    {
        get => (WarningState == AuthorizationWarningState.InvalidPassword) ? INVALID_PASSWORD_WARNING : string.Empty;
    }

    public ICommand SignInCommand => _signInCommand;

    public void OnSignInCommand(object? parametr)
    {
        if (!_model.Contains(Login))
        {
            WarningState = AuthorizationWarningState.InvalidLogin;
        }
        else if (!_model.ValidatePassword(Login, Password))
        {
            WarningState = AuthorizationWarningState.InvalidPassword;
        }
        else
        {
            SwitchToPage(new MainViewModel(Login));
        }
    }
    
    public ICommand BackCommand => _backCommand;

    public void OnBackCommand(object? parametr)
    {
        SwitchToPage(new MainViewModel());
    }
}


