using Goova.Subscriptions.Models.Models.Transactions;
using System;

namespace Goova.Subscriptions.Models.Requests.Subscriptions
{
    public class PaymentResponse
    {
        public int Law { get; set; }
        public DateTime Timestamp { get; set; }
        public int Installments { get; set; }
        public TransactionState Status { get; set; }
        public string ErrorString { get; set; }
        public int UserId { get; set; }
        public string CommerceId { get; set; }
        public decimal Amount { get; set; }
        public string TaxPercentage { get; set; }
        public int TransactionId { get; set; }
        public string ReferenceId { get; set; }
        public string Authorizaton { get; set; }
        public string Ticket { get; set; }
        public Currency Currency { get; set; }
        public string ExtendedResponse { get; set; }
        public bool Retry { get; set; } = false;
        public string Surnames { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string Gender { get; set; }
        public string InstrumentName { get; set; }
    }
}
