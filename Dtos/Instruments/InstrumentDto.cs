using System;

namespace Goova.Subscriptions.Models.Dtos.Instruments
{
    public class InstrumentDto
    {
        public DateTime Expiration { get; set; }
        public string InstrumentId { get; set; }
        public string IssuerImageUrl { get; set; }
        public string IssuerName { get; set; }
        public string Name { get; set; }
    }
}
