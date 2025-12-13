using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.WithDI
{
    public class OrderProcessor
    {
        private readonly SmsNotifier _smsNotifier;
        private readonly WhatsAppNotifier _whatsAppNotifier;
        private readonly DatabaseAuditLogger _auditLogger;

        public OrderProcessor(
            SmsNotifier smsNotifier,
            WhatsAppNotifier whatsAppNotifier,
            DatabaseAuditLogger auditLogger)
        {
            _smsNotifier = smsNotifier;
            _whatsAppNotifier = whatsAppNotifier;
            _auditLogger = auditLogger;
        }

        public void ProcessOrder()
        {
            _auditLogger.Log("Order processed");
            _smsNotifier.Notify("Order processed");
            _whatsAppNotifier.Notify("Order processed");
        }
    }
}
