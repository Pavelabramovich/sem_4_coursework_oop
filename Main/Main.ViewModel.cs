using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CourseProjectOpp;

public class MainViewModel : BaseViewModel
{
    private MainModel _model;

    private BaseState _state;

    private DelegateCommand _authorizationCommand;
    private DelegateCommand _unAuthorizationCommand;

    public MainViewModel()
    {
        _model = new MainModel();
        _state = new AnonimusState();

        _authorizationCommand = new DelegateCommand(OnAuthorizationCommand);
        _unAuthorizationCommand = new DelegateCommand(OnUnAuthorizationCommand);
    }
    public MainViewModel(string userName)
    {
        if (string.IsNullOrEmpty(userName))
            throw new ArgumentNullException();

        _model = new MainModel();
        _state = new AuthorizedState(userName);

        _authorizationCommand = new DelegateCommand(OnAuthorizationCommand);
        _unAuthorizationCommand = new DelegateCommand(OnUnAuthorizationCommand);


        //OnPropertyChanged(nameof(UserName));
    }



    public string UserName
    {
        get => _state switch
        {
            AuthorizedState aurhorizedState => aurhorizedState.UserName,

            AnonimusState => string.Empty,

            BaseState => throw new ArgumentException("Unknown state")
        };
    }

    public bool IsAuthorized => _state is AuthorizedState;
    public bool IsAnonimus => _state is AnonimusState;



    public ICommand AuthorizationCommand => _authorizationCommand;

    public void OnAuthorizationCommand(object? parametr)
    {
        SwitchToAuthorization();
    }

    private void SwitchToAuthorization() => _messenger.RaiseMessageValueChanged("CurrentViewModel", new AuthorizationViewModel());


    public ICommand UnAuthorizationCommand => _unAuthorizationCommand;

    public void OnUnAuthorizationCommand(object? parametr)
    {
        SwitchToLogOut();
    }

    private void SwitchToLogOut() => _messenger.RaiseMessageValueChanged("CurrentViewModel", new MainViewModel());


    private abstract class BaseState
    {

    }

    private class AuthorizedState : BaseState
    {
        public string UserName { get; init; }

        public AuthorizedState(string userName)
        {
            UserName = userName;
        }
    }

    private class AnonimusState : BaseState
    {

    }

}
