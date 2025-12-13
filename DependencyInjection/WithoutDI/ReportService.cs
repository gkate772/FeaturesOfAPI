using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.WithoutDI
{
    public class ReportService
    {
        private FileLogger _logger = new FileLogger();
        private EmailService _emailService = new EmailService();
        public void GenerateReport()
        {
            Console.WriteLine("Report generated");

            _logger.Log("Report generated successfully");
            _emailService.SendEmail("Report generated successfully");
        }
    }
}
