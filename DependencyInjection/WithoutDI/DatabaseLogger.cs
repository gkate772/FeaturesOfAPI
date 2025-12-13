using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.WithoutDI
{
    public class DatabaseLogger
    {
        public void LogToDatabase(string message)
        {
            Console.WriteLine("Logged to database: " + message);
        }
    }
}
