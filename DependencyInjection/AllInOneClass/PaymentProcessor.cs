using System;

namespace DependencyInjection.AllInOneClass
{
    public class PaymentProcessor : IPaymentProcessor
    {
        private readonly ISmsNotifier _smsNotifier;          // Constructor Injection
        //public IEmailNotifier EmailNotifier { get; set; }    // Property Injection
         private readonly IEmailNotifier _emailNotifier;          // Constructor Injection

        public PaymentProcessor(ISmsNotifier smsNotifier,IEmailNotifier emailNotifier)
        {
            _smsNotifier = smsNotifier
                ?? throw new ArgumentNullException(nameof(smsNotifier));
            _emailNotifier = emailNotifier 
                ?? throw new ArgumentNullException(nameof(emailNotifier));

        }

        // Method Injection
        public void ProcessPayment(IDatabaseLogger dbLogger)
        {
            if (dbLogger == null)
                throw new ArgumentNullException(nameof(dbLogger));

            if (_emailNotifier == null)
                throw new InvalidOperationException("EmailNotifier is not set.");

            dbLogger.Log("Payment processed");
            _smsNotifier.Send("Payment processed");
            _emailNotifier.Send("Payment processed");
        }
    }
}
