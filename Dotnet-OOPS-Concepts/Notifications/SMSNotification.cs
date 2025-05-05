using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_OOPS_Concepts.Notifications
{
    public class SMSNotification : Notification
    {
        public override void send(string to, string message)
        {
            Console.WriteLine($"[Email] to {to}, message {message}");
        }
    }
}
