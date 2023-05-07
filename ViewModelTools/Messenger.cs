using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOpp;

public class Messenger
{
    private static Messenger? _instance;

    public static Messenger Instance => _instance ??= new Messenger();

    private Messenger() { }


    public event EventHandler<MessageValueChangedEventArgs>? MessageValueChanged;


    public class MessageValueChangedEventArgs : EventArgs
    {
        public MessageValueChangedEventArgs(object message)
        {
            Message = message;
        }

        public object Message { get; set; }
    }

    public void RaiseMessageValueChanged(object message)
    {
        MessageValueChanged?.Invoke(this, new MessageValueChangedEventArgs(message));
    }
}
