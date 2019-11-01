using System.Collections.Generic;

namespace Goova.Subscriptions.Models.Subscriptors
{
    public class SubscriptorInfo
    {
        public int Id { get; set; }
        public string ExternalId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public ICollection<Instruments.Instrument> Instruments { get; set; }
    }
}
