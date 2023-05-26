using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CourseProjectOpp;

public class CustomerAbilitiesViewModel : BaseAbilitiesViewModel
{
    private bool _isNameChanging;

    private NameChangingViewModel _currentWindow;

    public CustomerAbilitiesViewModel(string login) 
        : base(login) 
    {
        _isNameChanging = false;

        _messenger.MessageValueChanged += OnMessengerValueChanged;

        _currentWindow = new NameChangingViewModel(_login);
    }

    public override ICommand ChangeUserCommand => new DelegateCommand(o =>
    {
        if (!_isNameChanging)
        {
            _isNameChanging = true;
            _currentWindow.IsVisible = true;
        }
    });


    public override ICommand BackCommand => new DelegateCommand(o =>
    {
        if (!_isNameChanging) 
            SwitchToPage<UserViewModel>();
    });


    public override ICommand ChangeProductsCommand => DelegateCommand.DoNothing;

    public override BaseViewModel CurrentWindow
    {
        get => _currentWindow;
    }


    protected void OnMessengerValueChanged(object? sender, Messenger.MessageValueChangedEventArgs e)
    {
        if (e.Message is WindowMessage windowMessage && windowMessage.WindowType == typeof(NameChangingViewModel))
        {
            _isNameChanging = windowMessage.Visibility;
        }
    }
}
