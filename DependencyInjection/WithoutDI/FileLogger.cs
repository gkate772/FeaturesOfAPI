using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.WithoutDI
{
    public class FileLogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging to file: : {message}");
        }
    }
}
