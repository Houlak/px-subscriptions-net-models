using Goova.Subscriptions.Models.Instruments;
using Goova.Subscriptions.Models.Subscriptions;
using Goova.Subscriptions.Models.Transactions;
using System.Collections.Generic;

namespace Goova.Subscriptions.Models.Subscriptors
{
    public class Subscriptor
    {
        public int Id { get; set; }
        public string ExternalId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public Instrument Instrument { get; set; }
        public ICollection<Subscription> Subscriptions { get; set; }
    }
}
