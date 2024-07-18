using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4OOP.Part03Q03
{
    internal interface INotificationService
    {
        void SendNotification(string recipient, string message);
    }
}
