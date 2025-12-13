using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.WithoutDI
{
    public class ReportService
    {
        // private FileLogger _logger = new FileLogger();
        // private EmailService _emailService = new EmailService();

        //private SmsService _smsService = new SmsService();
        //private WhatsAppService _whatsAppService = new WhatsAppService();
        //private DatabaseLogger _databaseLogger = new DatabaseLogger();

        //private SmsService _smsService;
        //private WhatsAppService _whatsAppService;
        //private DatabaseLogger _databaseLogger;

        //// Constructor uses concrete classes
        //public ReportService(SmsService smsService,
        //                     WhatsAppService whatsAppService,
        //                     DatabaseLogger databaseLogger)
        //{
        //    _smsService = smsService;
        //    _whatsAppService = whatsAppService;
        //    _databaseLogger = databaseLogger;
        //}


        //Property Usage
        public SmsService SmsService { get; set; }
        public WhatsAppService WhatsAppService { get; set; }
        public DatabaseLogger DatabaseLogger { get; set; }
        public void GenerateReport()
        {
            Console.WriteLine("Report generated");

            // _logger.Log("Report generated successfully");
            // _emailService.SendEmail("Report generated successfully");

            //_databaseLogger.LogToDatabase("Report generated");
            //_smsService.SendSms("Report generated");
            //_whatsAppService.SendWhatsApp("Report generated");

            DatabaseLogger.LogToDatabase("Report generated");
            SmsService.SendSms("Report generated");
            WhatsAppService.SendWhatsApp("Report generated");
        }
    }
}
