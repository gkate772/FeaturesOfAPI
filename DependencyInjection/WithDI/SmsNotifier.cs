using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.WithDI
{
    public class SmsNotifier
    {
        public void Notify(string message)
        {
            Console.WriteLine("SMS Notification: " + message);
        }
    }
}
