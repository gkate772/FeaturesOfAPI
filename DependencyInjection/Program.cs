using DependencyInjection.AllInOneClass;
using DependencyInjection.WithDI;
using DependencyInjection.WithoutDI;
using DatabaseLogger = DependencyInjection.AllInOneClass.DatabaseLogger;
using SmsNotifier = DependencyInjection.AllInOneClass.SmsNotifier;
using Microsoft.Extensions.DependencyInjection;


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
        //var processor = new OrderProcessor
        //{
        //    SmsNotifier = new SmsNotifier(),
        //    WhatsAppNotifier = new WhatsAppNotifier(),
        //    AuditLogger = new DatabaseAuditLogger()
        //};

        //processor.ProcessOrder();

        //Method Injection(Without Interfaces)

        //var processor = new OrderProcessor();

        //processor.ProcessOrder(
        //    new SmsNotifier(),
        //    new WhatsAppNotifier(),
        //    new DatabaseAuditLogger()
        //);


        // // Constructor Injection
        //var sms = new SmsNotifier();
        //var processor = new PaymentProcessor(sms);

        //// Property Injection
        //processor.EmailNotifier = new EmailNotifier();

        //// Method Injection
        //var dbLogger = new DatabaseLogger();
        //processor.ProcessPayment(dbLogger);

        //// 1️ Constructor Injection
        //ISmsNotifier smsNotifier = new SmsNotifier();
        //IPaymentProcessor paymentProcessor = new PaymentProcessor(smsNotifier);

        //// 2️ Property Injection
        //paymentProcessor.EmailNotifier = new EmailNotifier();

        //// 3️ Method Injection
        //IDatabaseLogger databaseLogger = new DatabaseLogger();

        //paymentProcessor.ProcessPayment(databaseLogger);

        //Console.ReadLine();


        //Configure Container (Service Registration)
        var services = new ServiceCollection();
        // Register services
        services.AddTransient<ISmsNotifier, SmsNotifier>();
        services.AddScoped<IEmailNotifier, EmailNotifier>();
        services.AddSingleton<IDatabaseLogger, DatabaseLogger>();
        services.AddTransient<IPaymentProcessor, PaymentProcessor>();

        // Build container
        var serviceProvider = services.BuildServiceProvider();

        //Resolve Services
        var processer = serviceProvider.GetRequiredService<IPaymentProcessor>();
        var logger = serviceProvider.GetRequiredService<IDatabaseLogger>();

        processer.ProcessPayment(logger);


        //Transient
        var a = serviceProvider.GetService<ISmsNotifier>();
        var b = serviceProvider.GetService<ISmsNotifier>();
        var data = a != b; //(different instances)

        //Scoped
        var c = serviceProvider.GetService<IEmailNotifier>();
        var d = serviceProvider.GetService<IEmailNotifier>();
        var data1 = c == d; //(same instances)


        //Singleton
        var e = serviceProvider.GetService<IDatabaseLogger>();
        var f = serviceProvider.GetService<IDatabaseLogger>();
        var data2 = e == f; //(same instance always)




    }
}