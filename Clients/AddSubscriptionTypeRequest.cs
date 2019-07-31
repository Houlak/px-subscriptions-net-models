using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Clients
{
    public class AddSubscriptionTypeRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Frequence { get; set; }
        public decimal SubscriptionCost { get; set; }
    }
}
