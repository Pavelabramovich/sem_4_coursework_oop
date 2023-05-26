using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CourseProjectOpp;

public class NameChangingViewModel : SwitchebleViewModel
{
    private string _newName;

    private bool _isVisible;

    private string _login;

    private NameChangingModel _model;


    public NameChangingViewModel(string login)
    {
        _newName = string.Empty;
        _login = login;

        _model = new NameChangingModel();

        _isVisible = false;
        OnPropertyChanged(nameof(IsVisible));
    }

    public string NewName
    {
        get => _newName;
        set
        {
            if (value == _newName) 
                return;

            _newName = value;
            OnPropertyChanged();
        }
    }

    public bool IsVisible
    {
        get => _isVisible;
        set
        {
            if (_isVisible == value)
                return;

            _isVisible = value;
            OnPropertyChanged();

            _messenger.RaiseMessageValueChanged(new WindowMessage(this.GetType(), value));
        }
    }

    public ICommand SaveChangesCommand => new DelegateCommand(o =>
    {
        if (!string.IsNullOrEmpty(_newName))
        {
            _model.SetName(_login, _newName);

            IsVisible = false;
        }   
    });

    public ICommand CancelCommand => new DelegateCommand(o =>
    {
        IsVisible = false;

        NewName = string.Empty;
    });
}
