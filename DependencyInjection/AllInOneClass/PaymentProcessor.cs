using System;

namespace DependencyInjection.AllInOneClass
{
    public class PaymentProcessor : IPaymentProcessor
    {
        private readonly ISmsNotifier _smsNotifier;          // Constructor Injection
        public IEmailNotifier EmailNotifier { get; set; }    // Property Injection

        public PaymentProcessor(ISmsNotifier smsNotifier)
        {
            _smsNotifier = smsNotifier
                ?? throw new ArgumentNullException(nameof(smsNotifier));
        }

        // Method Injection
        public void ProcessPayment(IDatabaseLogger dbLogger)
        {
            if (dbLogger == null)
                throw new ArgumentNullException(nameof(dbLogger));

            if (EmailNotifier == null)
                throw new InvalidOperationException("EmailNotifier is not set.");

            dbLogger.Log("Payment processed");
            _smsNotifier.Send("Payment processed");
            EmailNotifier.Send("Payment processed");
        }
    }
}
