using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Payments
{
    public class PaymentRequest
    {
        public int TransactionId { get; set; }
        public string InstrumentTokenId { get; set; }
        public int InternalSubscriptorId { get; set; }
        public int? ComerceIdentification { get; set; }
        public decimal Amount { get; set; }
        public Currency Currency { get; set; }
    }

    public enum Currency
    {
        UruguayanPeso = 0,
        Dolar = 1,
        Any = 99
    }
}
