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


        ReportService reportService = new ReportService();

        reportService.GenerateReport(
            new SmsService(),
            new WhatsAppService(),
            new DatabaseLogger()
        );
    }
}