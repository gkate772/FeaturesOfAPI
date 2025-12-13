using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.WithoutDI
{
    public class EmailService
    {
        public void SendEmail(string message)
        {
            Console.WriteLine("Sending email: " + message);
        }
    }
}
