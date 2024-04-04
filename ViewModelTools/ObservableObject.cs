using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOpp;


public class ObservableObject : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        VerifyPropertyName(propertyName);
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    [Conditional("DEBUG")]
    private void VerifyPropertyName(string? propertyName)
    {
        ArgumentException
            .ThrowIfNullOrEmpty(propertyName, nameof(propertyName));

        if (TypeDescriptor.GetProperties(this)[propertyName] is null)       
            throw new ArgumentNullException($"{GetType().Name} does not contain property: {propertyName}");      
    }
}
