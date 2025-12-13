using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.AllInOneClass
{
    public class EmailNotifier : IEmailNotifier
    {
        public void Send(string message)
        {
            Console.WriteLine("Email: " + message);
        }
    }
}
