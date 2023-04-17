using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOpp;


public abstract class ViewModelBase : INotifyPropertyChanged
{
    protected Messenger _messenger;

    public ViewModelBase()
    {
        _messenger = Messenger.Instance;
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        VerifyPropertyName(propertyName);
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    [Conditional("DEBUG")]
    private void VerifyPropertyName(string? propertyName)
    {
        if (string.IsNullOrEmpty(propertyName))
        {
            throw new ArgumentNullException($"{nameof(propertyName)} is null or empty.");
        }

        if (TypeDescriptor.GetProperties(this)[propertyName] is null)
        {
            throw new ArgumentNullException($"{GetType().Name} does not contain property: {propertyName}");
        }
    }
}