using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.WithoutDI
{
    public class SmsService
    {
        public void SendSms(string message)
        {
            Console.WriteLine("SMS sent: " + message);
        }
    }
}
