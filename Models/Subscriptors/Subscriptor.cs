using Goova.Subscriptions.Models.Models.Instruments;
using Goova.Subscriptions.Models.Models.Subscriptions;
using Goova.Subscriptions.Models.Models.Transactions;
using System;
using System.Collections.Generic;

namespace Goova.Subscriptions.Models.Models.Subscriptors
{
    public class Subscriptor
    {
        public int Id { get; set; }
        public string ExternalId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string PostalCode { get; set; }
        public string FullName { get; set; }
        public Instrument Instrument { get; set; }
        public ICollection<Subscription> Subscriptions { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
        public DateTime FirstSubscribed { get; set; }
    }
}
