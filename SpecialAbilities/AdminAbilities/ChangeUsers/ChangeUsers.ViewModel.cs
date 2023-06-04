using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CourseProjectOpp;

public class UserModel : ObservableObject
{
    private string _login;

    private string _name;
    private UserRole _role;

    private int _discount;

    private string _avatarPath;

    public UserModel(string login, string name, UserRole role, int discount, string avatarPath)
    {
        _login = login;

        _name = name;
        _role = role;

        _discount = discount;

        _avatarPath = avatarPath;
    }

    public string Login => _login;

    public string Name
    {
        get => _name;
        set 
        {
            if (_name == value)
                return;

            _name = value;
            OnPropertyChanged();
        }
    }

    public UserRole Role
    {
        get => _role;
        set
        {
            if (value == _role)
                return;

            _role = value;
            OnPropertyChanged();
        }
    }

    public int Discount
    {
        get => _discount;
        set
        {
            if (value == _discount)
                return;

            _discount = value;
            OnPropertyChanged();
        }
    }

    public string AvatarPath
    {
        get => _avatarPath;
        set
        {
            if (_avatarPath == value)
                return;

            _avatarPath = value;
            OnPropertyChanged();
        }
    }
}

public class ChangeUsersViewModel : SwitchebleViewModel
{
    private ChangeUsersModel _model;

    private string _login;

    public ObservableCollection<UserModel> Users { get; set; }

    public ChangeUsersViewModel(string login)
    {
        _model = new ChangeUsersModel();

        _login = login;

        Users = new( _model.Logins.Where(l => l != _login).Select(l => CreateUserModel(l)) );
    }


    public ICommand CancelCommand => new DelegateCommand(o =>
    {
        SwitchToPage<SpecialAbilitiesViewModel>();
    });


    public ICommand SaveChangesCommand => new DelegateCommand(o =>
    {
        foreach (var model in Users)
        {
            _model.UpdateUser(model.Login, model.Name, model.Role, model.Discount, model.AvatarPath); ;
        }

        SwitchToPage<SpecialAbilitiesViewModel>();
    });

    public override ICommand BackCommand => CancelCommand;

    private UserModel CreateUserModel(string login)
    {
        return new UserModel(login, _model.GetName(login), _model.GetRole(login), _model.GetDiscount(login), _model.GetAvatar(login));
    }
}
