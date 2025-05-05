using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_OOPS_Concepts.Notifications
{
    public abstract class Notification : INotificationService
    {
        public abstract void send(string to, string message);
        
    }
}
