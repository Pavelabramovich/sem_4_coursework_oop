using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Xml.Linq;

namespace CourseProjectOpp;

class RegistrationViewModel : SwitchebleViewModel
{
    private enum RegistrationWarningState
    {
        NoWarnings = 0,
        InvalidLogin = 1,
        InvalidPassword = 2,
    }

    private RegistrationModel _model;


    private string _login;

    
    private IEnumerable<char> _password;
    private IEnumerable<char> _repeatedPassword;

    private bool _isPasswordUnmasked;

    private RegistrationWarningState _warningState;

    private const string INVALID_LOGIN_WARNING = "Invalid login";
    private const string INVALID_PASSWORD_WARNING = "Invalid password";


    public RegistrationViewModel()
    {
        _model = new RegistrationModel();

        _login = string.Empty;

        _password = string.Empty;
        _repeatedPassword = string.Empty;

        _isPasswordUnmasked = false;

        _warningState = RegistrationWarningState.NoWarnings;

        //_signInCommand = new DelegateCommand(OnSignInCommand);
        //_backCommand = new DelegateCommand(OnBackCommand);
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

            WarningState = RegistrationWarningState.NoWarnings;
        }
    }

    public IEnumerable<char> Password
    {
        get => _password;
        set
        {
            if (Enumerable.SequenceEqual(value, _password))
                return;

            _password = value;
            OnPropertyChanged();

            WarningState = RegistrationWarningState.NoWarnings;
        }
    }

    public IEnumerable<char> RepeatedPassword
    {
        get => _repeatedPassword;
        set
        {
            if (Enumerable.SequenceEqual(value, _repeatedPassword))
                return;

            _repeatedPassword = value;
            OnPropertyChanged();

            WarningState = RegistrationWarningState.NoWarnings;
        }
    }


    //public string UnsecurePassword
    //{
    //    get => _unsecurePassword;
    //    set
    //    {
    //        if (value == _unsecurePassword)
    //            return;

    //        _unsecurePassword = value;
    //        OnPropertyChanged();

    //        WarningState = RegistrationWarningState.NoWarnings;
    //    }
    //}

    //private IEnumerable<char> Password
    //{
    //    get => IsPasswordMasked ? SecurePassword.GetCharSequance() : UnsecurePassword;
    //}

    //public bool IsPasswordUnmasked
    //{
    //    get => _isPasswordUnmasked;
    //    set
    //    {
    //        if (value == _isPasswordUnmasked)
    //            return;

    //        _isPasswordUnmasked = value;

    //        if (value)
    //        {
    //            UnsecurePassword = SecurePassword.ToUnsecureString();
    //        }
    //        else
    //        {
    //            SecurePassword = UnsecurePassword.ToSecureString();
    //        }

    //        OnPropertyChanged(nameof(IsPasswordMasked));
    //        OnPropertyChanged(nameof(IsPasswordUnmasked));
    //    }
    //}
    //public bool IsPasswordMasked => !IsPasswordUnmasked;

    private RegistrationWarningState WarningState
    {
        get => _warningState;
        set
        {
            if (value == _warningState)
                return;

            _warningState = value;

            //OnPropertyChanged(nameof(InvalidLoginWarning));
            //OnPropertyChanged(nameof(InvalidPasswordWarning));
        }
    }

    public string InvalidLoginWarning
    {
        get => (WarningState == RegistrationWarningState.InvalidLogin) ? INVALID_LOGIN_WARNING : string.Empty;
    }
    public string InvalidPasswordWarning
    {
        get => (WarningState == RegistrationWarningState.InvalidPassword) ? INVALID_PASSWORD_WARNING : string.Empty;
    }

    //public ICommand SignInCommand => _signInCommand;

    //public void OnSignInCommand(object? parametr)
    //{
    //    if (!_model.Contains(Login))
    //    {
    //        WarningState = RegistrationWarningState.InvalidLogin;
    //    }
    //    else if (!_model.ValidatePassword(Login, Password))
    //    {
    //        WarningState = RegistrationWarningState.InvalidPassword;
    //    }
    //    else
    //    {
    //        UpdatePage(new UserViewModel(Login));
    //        SwitchToPage<UserViewModel>();
    //    }
    //}

    //public ICommand BackCommand => _backCommand;

    //public void OnBackCommand(object? parametr)
    //{
    //    SwitchToPage<UserViewModel>();
    //}



    public ICommand RegistrationCommand => new DelegateCommand(o =>
    {
        foreach (char c in Password)
        {
            var d = c;
        }
    });
}


