using DependencyInjection.WithoutDI;

internal class Program
{
    private static void Main(string[] args)
    {
        ReportService reportService = new ReportService();
        reportService.GenerateReport();
    }
}