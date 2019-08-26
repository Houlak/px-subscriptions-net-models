using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Clients
{
    public class UpdateSubscriptionTypeRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal SubscriptionCost { get; set; }
    }
}
