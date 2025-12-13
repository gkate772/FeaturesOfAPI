namespace DependencyInjection.AllInOneClass
{
    public interface IPaymentProcessor
    {
        //IEmailNotifier EmailNotifier { get; set; }

        void ProcessPayment(IDatabaseLogger dbLogger);
    }
}