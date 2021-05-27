using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Subscriptors
{
    public class SubscriptorDataNotif
    {
        public string ExternalId { get; set; }

        public Dictionary<string, string> Fields { get; set; }
    }
}
