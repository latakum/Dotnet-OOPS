using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_OOPS_Concepts.Notifications
{
    //Abstraction
    public interface INotificationService
    {
        void send(string to, string message);
    }
}
