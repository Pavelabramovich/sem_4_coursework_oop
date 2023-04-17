using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOpp;

public class Messenger
{
    private static Messenger? _instance;

    public static Messenger Instance => _instance ??= new Messenger();


    public event EventHandler<MessageValueChangedEventArgs>? MessageValueChanged;


    public class MessageValueChangedEventArgs : EventArgs
    {
        public MessageValueChangedEventArgs(string propertyName, object newValue)
        {
            PropertyName = propertyName;
            NewValue = newValue;
        }

        public string PropertyName { get; set; }
        public object NewValue { get; set; }
    }

    public void RaiseMessageValueChanged(string propertyName, object value)
    {
        MessageValueChanged?.Invoke(this, new MessageValueChangedEventArgs(propertyName, value));
    }
}
