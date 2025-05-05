using Dotnet_OOPS_Concepts.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_OOPS_Concepts.Services
{
    public class NotificationService
    {
        private readonly List<INotificationService> _channels;

        public NotificationService(List<INotificationService> channels)
        {
            _channels = channels;
        }

        public void NotifyUser(string userContact, string message)
        {
            foreach (var channel in _channels)
            {
                channel.send(userContact, message); // Run-time polymorphism
            }
        }
    }
}
