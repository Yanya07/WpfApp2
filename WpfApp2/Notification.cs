using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    internal class Notification
    {
        public event Action<string> OnMessageNotification;
        public event Action<string> OnCallNotification;
        public event Action<string> OnEmailNotification;

        public void SendMessage(string message)
        {
            OnMessageNotification?.Invoke(message);
        }

        public void MakeCall(string phoneNumber)
        {
            OnCallNotification?.Invoke(phoneNumber);
        }

        public void SendEmail(string email)
        {
            OnEmailNotification?.Invoke(email);
        }
    }
}
