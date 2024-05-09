using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Models.Instruments
{
    public class Instrument
    {
        public DateTime Expiration { get; set; }
        public string InstrumentId { get; set; }
        public string IssuerImageUrl { get; set; }
        public string IssuerName { get; set; }
        public string Name { get; set; }
        public string Token { get; set; }
    }
}
