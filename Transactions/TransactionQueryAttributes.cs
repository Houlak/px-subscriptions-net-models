using System;

namespace Goova.Subscriptions.Models.Transactions
{
    public class TransactionQueryAttributes
    {
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public decimal? MinAmount { get; set; }
        public decimal? MaxAmount { get; set; }
        public int? Currency { get; set; } = 99; //Any by default
        public int Page { get; set; } = 1;
        public int Limit { get; set; } = 5;
    }
}