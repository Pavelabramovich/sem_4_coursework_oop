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


    private string _invalidLoginWarning;
    private string _invalidPasswordWarning;
    private string _invalidRepeatedPasswordWarning;
    private string _invalidNameWarning;


    private string _login;
    private string _name;




    
    private IEnumerable<char> _password;
    private IEnumerable<char> _repeatedPassword;




    public RegistrationViewModel()
    {
        _model = new RegistrationModel();

        _login = string.Empty;
        _name = string.Empty;

        _password = string.Empty;
        _repeatedPassword = string.Empty;




        _invalidLoginWarning = string.Empty;
        _invalidNameWarning = string.Empty;
        _invalidPasswordWarning = string.Empty;
        _invalidRepeatedPasswordWarning = string.Empty;
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

            InvalidLoginWarning = string.Empty;
        }
    }

    public string Name
    {
        get => _name;
        set
        {
            if (value == _name)
                return;

            _name = value;
            OnPropertyChanged();

            InvalidNameWarning = string.Empty;
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


            InvalidPasswordWarning = string.Empty;

            if (InvalidRepeatedPasswordWarning == "Passwords are different") 
                InvalidRepeatedPasswordWarning = string.Empty;
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

            InvalidRepeatedPasswordWarning = string.Empty;
        }
    }


    public string InvalidLoginWarning
    {
        get => _invalidLoginWarning;
        set
        {
            if (_invalidLoginWarning == value)
                return;

            _invalidLoginWarning = value;
            OnPropertyChanged();
        }
    }
    public string InvalidNameWarning
    {
        get => _invalidNameWarning;
        set
        {
            if (_invalidNameWarning == value)
                return;

            _invalidNameWarning = value;
            OnPropertyChanged();
        }
    }
    public string InvalidPasswordWarning
    {
        get => _invalidPasswordWarning;
        set
        {
            if (_invalidPasswordWarning == value)
                return;

            _invalidPasswordWarning = value;
            OnPropertyChanged();
        }
    }
    public string InvalidRepeatedPasswordWarning
    {
        get => _invalidRepeatedPasswordWarning;
        set
        {
            if (_invalidRepeatedPasswordWarning == value)
                return;

            _invalidRepeatedPasswordWarning = value;
            OnPropertyChanged();
        }
    }



    public override ICommand BackCommand => new DelegateCommand(o =>
    {
        UpdatePage(new AuthorizationViewModel());
        SwitchToPage<AuthorizationViewModel>();
    });




    public ICommand RegistrationCommand => new DelegateCommand(o =>
    {
        InvalidLoginWarning = string.Empty;
        InvalidNameWarning = string.Empty;
        InvalidPasswordWarning = string.Empty;
        InvalidRepeatedPasswordWarning = string.Empty;

        var loginValidator = new LoginValidator();
        var res = loginValidator.IsValid(Login);

        if (!res)
        {
            InvalidLoginWarning = res.Message!;
            return;
        }

        if (_model.ContainsLogin(Login))
        {
            InvalidLoginWarning = "User with this login already exists";
            return;
        }

        var nameValidator = new NameValidator();
        res = nameValidator.IsValid(Name);

        if (!res)
        {
            InvalidNameWarning = res.Message!;
            return;
        }

        var passwordValidator = new PasswordValidator();
        res = passwordValidator.IsValid(Password);

        if (!res)
        {
            InvalidPasswordWarning = res.Message!;
            return;
        }

        res = passwordValidator.IsValid(RepeatedPassword);
        if (!res)
        {
            InvalidRepeatedPasswordWarning = res.Message!;
            return;
        }

        if (!Enumerable.SequenceEqual(Password, RepeatedPassword))
        {
            InvalidRepeatedPasswordWarning = "Passwords are different";
            return;
        }

        _model.AddUser(Login, Password, Name);


        UpdatePage(new UserViewModel(Login));
        SwitchToPage<UserViewModel>();

    });
    
}


