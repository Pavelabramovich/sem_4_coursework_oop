using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CourseProjectOpp;


public class DelegateCommand : ICommand
{
    private readonly Action<object?> _executeAction;
    private readonly Func<object?, bool> _canExecute;


    public DelegateCommand(Action<object?> executeAction, Func<object?, bool> canExecute)
    {
        _executeAction = executeAction;
        _canExecute = canExecute;
    }
    public DelegateCommand(Action<object?> executeAction) 
        : this(executeAction, AlwaysCanExecute) 
    { }


    public event EventHandler? CanExecuteChanged;


    public void Execute(object? parameter) => _executeAction(parameter);

    public bool CanExecute(object? parameter) => _canExecute?.Invoke(parameter) ?? true;

    public void InvokeCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);


    public static Func<object?, bool> AlwaysCanExecute => ( (obj) => true );

    public static Func<object?, bool> NeverCanExecute => ( (obj) => false );

    public static DelegateCommand DoNothing => new DelegateCommand(o => { });

    public static DelegateCommand CantExecute => new DelegateCommand(o => { }, NeverCanExecute );
}
