using DependencyInjection.WithDI;
using DependencyInjection.WithoutDI;

internal class Program
{
    private static void Main(string[] args)
    {
        //ReportService reportService = new ReportService(new SmsService(), new WhatsAppService(), new DatabaseLogger());
        //ReportService reportService = new ReportService()
        //{
        //    SmsService = new SmsService(),
        //    WhatsAppService = new WhatsAppService(),
        //    DatabaseLogger = new DatabaseLogger()
        //};
        //reportService.GenerateReport();


        //ReportService reportService = new ReportService();

        //reportService.GenerateReport(
        //    new SmsService(),
        //    new WhatsAppService(),
        //    new DatabaseLogger()
        //);


        //With DI
        //var sms = new SmsNotifier();
        //var whatsapp = new WhatsAppNotifier();
        //var logger = new DatabaseAuditLogger();

        //var processor = new OrderProcessor(sms, whatsapp, logger);
        //processor.ProcessOrder();

        //Property Injection (Without Interfaces)
        var processor = new OrderProcessor
        {
            SmsNotifier = new SmsNotifier(),
            WhatsAppNotifier = new WhatsAppNotifier(),
            AuditLogger = new DatabaseAuditLogger()
        };

        processor.ProcessOrder();
    }
}