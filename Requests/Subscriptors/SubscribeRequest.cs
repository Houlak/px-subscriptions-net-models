using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Requests.Subscriptors
{
    public class SubscribeRequest
    {
        public string ExternalId { get; set; }
        public int SubscriptionTypeId { get; set; }
        public string LegalId { get; set; } //RUT uruguay
        public string CiberSourceFingerPrint { get; set; }
    }
}
