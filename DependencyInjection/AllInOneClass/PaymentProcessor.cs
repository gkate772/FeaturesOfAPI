using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.AllInOneClass
{
    public class PaymentProcessor
    {
        private readonly SmsNotifier _smsNotifier;          // Constructor
        public EmailNotifier EmailNotifier { get; set; }    // Property

        // 1️⃣ Constructor Injection (without interfaces)
        public PaymentProcessor(SmsNotifier smsNotifier)
        {
            _smsNotifier = smsNotifier;
        }

        // 3️⃣ Method Injection (without interfaces)
        public void ProcessPayment(DatabaseLogger dbLogger)
        {
            dbLogger.Log("Payment processed");
            _smsNotifier.Send("Payment processed");
            EmailNotifier.Send("Payment processed");
        }
    }
}
