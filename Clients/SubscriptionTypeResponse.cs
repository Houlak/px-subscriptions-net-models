using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Clients
{
    public class SubscriptionTypeResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public SubscriptionFrequence Frequence { get; set; }
        public double SubscriptionCost { get; set; }
    }
}
