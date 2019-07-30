using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Payments
{
    public class PaymentResponse
    {
        public int Law { get; set; }
        public DateTime Timestamp { get; set; }
        public int Installments { get; set; }
        public TransactionState Status { get; set; }
        public int UserId { get; set; }
        public string CommerceId { get; set; }
        public decimal Amount { get; set; }
        public int TransactionId { get; set; }
        public string ReferenceId { get; set; }
        public string Authorizaton { get; set; }
        public string Ticket { get; set; }
    }
}
