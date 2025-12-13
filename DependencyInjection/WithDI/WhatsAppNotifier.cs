using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.WithDI
{
    public class WhatsAppNotifier
    {
        public void Notify(string message)
        {
            Console.WriteLine("WhatsApp Notification: " + message);
        }
    }
}
