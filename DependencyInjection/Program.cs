using DependencyInjection.WithoutDI;

internal class Program
{
    private static void Main(string[] args)
    {
        ReportService reportService = new ReportService(new SmsService(), new WhatsAppService(), new DatabaseLogger());
        reportService.GenerateReport();
    }
}