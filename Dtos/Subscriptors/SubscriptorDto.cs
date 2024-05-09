using Goova.Subscriptions.Models.Dtos.Instruments;
using Goova.Subscriptions.Models.Dtos.Subscriptions;
using Goova.Subscriptions.Models.Dtos.Transactions;
using System;
using System.Collections.Generic;

namespace Goova.Subscriptions.Models.Dtos.Subscriptors
{
    public class SubscriptorDto
    {
        public int Id { get; set; }
        public string ExternalId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string PostalCode { get; set; }
        public string FullName { get; set; }
        public InstrumentDto Instrument { get; set; }
        public ICollection<SubscriptionDto> Subscriptions { get; set; }
        public ICollection<TransactionDto> Transactions { get; set; }
        public DateTime FirstSubscribed { get; set; }
    }
}
