using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.AllInOneClass
{
    public class EmailNotifier
    {
        public void Send(string message)
        {
            Console.WriteLine("Email: " + message);
        }
    }
}
