using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.AllInOneClass
{
    public class SmsNotifier
    {
        public void Send(string message)
        {
            Console.WriteLine("SMS: " + message);
        }
    }
}
