using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.WithoutDI
{
    public class WhatsAppService
    {
        public void SendWhatsApp(string message)
        {
            Console.WriteLine("WhatsApp message sent: " + message);
        }
    }
}
