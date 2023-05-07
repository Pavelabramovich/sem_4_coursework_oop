using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CourseProjectOpp;

public interface IAuthorizationViewModel
{
    public string Login { get; }

    public SecureString SecurePassword { get; }
    public string UnsecurePassword { get; }

    public bool IsPasswordUnmasked { get; }
    public bool IsPasswordMasked => !IsPasswordUnmasked;

    public string InvalidLoginWarning { get; }
    public string InvalidPasswordWarning { get; }

    public ICommand SignInCommand { get; }
    public ICommand BackCommand { get; }
}