using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.WithDI
{
    public class DatabaseAuditLogger
    {
        public void Log(string message)
        {
            Console.WriteLine("DB Log: " + message);
        }
    }
}
