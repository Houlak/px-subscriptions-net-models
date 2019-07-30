using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Payments
{
    public class PaymentRequest
    {
        public int TransactionId { get; set; }
        public string InstrumentTokenId { get; set; }
        public int InternalConsumerId { get; set; }
        public int? ComerceIdentification { get; set; }
        public decimal Amount { get; set; }
    }
}
