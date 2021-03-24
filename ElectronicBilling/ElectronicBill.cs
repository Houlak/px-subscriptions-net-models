using Goova.Subscriptions.Models.Transactions;
using System.Collections.Generic;

namespace Goova.Subscriptions.Models.ElectronicBilling
{
    public class ElectronicBill
    {
        public int InternalId { get; set; }
        public string CAENumber { get; set; }
        public string Series { get; set; }
        public int Number { get; set; }
    }
}
