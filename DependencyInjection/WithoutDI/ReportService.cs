using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.WithoutDI
{
    public class ReportService
    {
        // private FileLogger _logger = new FileLogger();
        // private EmailService _emailService = new EmailService();

        private SmsService _smsService = new SmsService();
        private WhatsAppService _whatsAppService = new WhatsAppService();
        private DatabaseLogger _databaseLogger = new DatabaseLogger();
        public void GenerateReport()
        {
            Console.WriteLine("Report generated");

            // _logger.Log("Report generated successfully");
            // _emailService.SendEmail("Report generated successfully");

            _databaseLogger.LogToDatabase("Report generated");
            _smsService.SendSms("Report generated");
            _whatsAppService.SendWhatsApp("Report generated");
        }
    }
}
