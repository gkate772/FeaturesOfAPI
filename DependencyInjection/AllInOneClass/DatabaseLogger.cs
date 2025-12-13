using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.AllInOneClass
{
    public class DatabaseLogger : IDatabaseLogger
    {
        public void Log(string message)
        {
            Console.WriteLine("DB Log: " + message);
        }
    }
}
