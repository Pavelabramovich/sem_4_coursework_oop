using System.Windows.Controls;
using System.Windows;
using Microsoft.Xaml.Behaviors;
using System.Security;

namespace CourseProjectOpp;

public class PasswordBehavior : Behavior<PasswordBox>
{
    public static readonly DependencyProperty SecurePasswordProperty =
        DependencyProperty.Register("SecurePassword", typeof(SecureString), typeof(PasswordBehavior), new PropertyMetadata(default(SecureString)));

    private bool _skipUpdate;

    public SecureString SecurePassword
    {
        get => (SecureString)GetValue(SecurePasswordProperty); 
        set => SetValue(SecurePasswordProperty, value); 
    }

    protected override void OnAttached()
    {
        AssociatedObject.PasswordChanged += PasswordBox_PasswordChanged;
    }

    protected override void OnDetaching()
    {
        AssociatedObject.PasswordChanged -= PasswordBox_PasswordChanged;
    }

    protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
    {
        base.OnPropertyChanged(e);

        if (e.Property == SecurePasswordProperty && !_skipUpdate)
        {
            _skipUpdate = true;

            if (e.NewValue is SecureString str)
            {
                AssociatedObject.SecurePassword.Clear();
                AssociatedObject.SecurePassword.AddRange(str);
            }
            else
            {
                AssociatedObject.Password = null;
            }

            _skipUpdate = false;     
        }
    }

    private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
    {
        _skipUpdate = true;
        SecurePassword = AssociatedObject.SecurePassword;
        _skipUpdate = false;
    }
}