using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Win32;


namespace CourseProjectOpp;

public class CustomerAbilitiesViewModel : BaseAbilitiesViewModel
{
    private CustomerAbilitiesModel _model;

    public event Action? NameChanged;
    public event Action? AvatarChanged;

    public CustomerAbilitiesViewModel(string login) 
        : base(login) 
    { 
        _model = new CustomerAbilitiesModel();
    }

    public override ICommand ChangeUserCommand => new DelegateCommand(o =>
    {
        var newName = ChangeNameBox.Show("Enter new name:", new NameValidator());

        if (newName is null)
            return;

        _model.UpdeateName(_login, newName);
        NameChanged?.Invoke();
    });

    public override ICommand ChangeAvatarCommand => new DelegateCommand(o =>
    {
        OpenFileDialog op = new OpenFileDialog();
        op.Title = "Select a picture";
        op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
          "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
          "Portable Network Graphic (*.png)|*.png";

        if (op.ShowDialog() == true)
        {
            string filePath = op.FileName;

            if (File.Exists(filePath))
            {
                _model.UpdateAvatar(_login, filePath);
                AvatarChanged?.Invoke();
            }
        }
    });

    public override ICommand BackCommand => new DelegateCommand(o =>
    {
        SwitchToPage<UserViewModel>();
    });


    public override ICommand ChangeProductsCommand => DelegateCommand.DoNothing;
}
