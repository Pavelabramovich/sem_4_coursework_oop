using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CourseProjectOpp;

public partial class MainViewModel
{
    private abstract class BaseStrategy
    {
        protected Messenger _messenger = Messenger.Instance;
        protected MainModel _model;

        public BaseStrategy(MainModel model)
        {
            _model = model;
        }

        public abstract string UserName { get; }
        public abstract ICommand AuthorizationCommand { get; }



        protected void SwitchToPage(BaseViewModel otherPage)
        {
            _messenger.RaiseMessageValueChanged("CurrentViewModel", otherPage);
        }

        protected DelegateCommand SwitchToPageCommand(BaseViewModel otherPage)
        {
            return new DelegateCommand((o) => SwitchToPage(otherPage));
        }
    }

    private class AnonymousStrategy : BaseStrategy
    {
        public AnonymousStrategy(MainModel model) : 
            base(model) 
        { }

        public override string UserName => string.Empty;
        public override ICommand AuthorizationCommand => SwitchToPageCommand(new AuthorizationViewModel());
    }

    private abstract class AuthorizedStrategy : BaseStrategy
    {
        protected string _login;

        public AuthorizedStrategy(MainModel model, string login) :
            base(model)
        {
            _login = login;
        }

        public override string UserName => _model.GetName(_login);
        public override ICommand AuthorizationCommand => SwitchToPageCommand(new MainViewModel());
    }

    private class UserStrategy : AuthorizedStrategy
    {
        public UserStrategy(MainModel model, string login) :
            base(model, login)
        { }
    }
}
