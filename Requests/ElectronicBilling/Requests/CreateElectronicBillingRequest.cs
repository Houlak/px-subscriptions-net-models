
using Goova.Subscriptions.Models.Dtos.ElectronicBilling;
using Goova.Subscriptions.Models.Enumerables;

namespace Goova.Subscriptions.Models.Requests.ElectronicBilling.Requests
{
    public class CreateElectronicBillingRequest
    {
        public string SubscriptorName { get; set; }
        public string TaxPercentage { get; set; }
        public Currency Currency { get; set; }
        public bool IsCancellation { get; set; }
        public string Rut { get; set; }
        public string SocialReason { get; set; }
        public decimal Amount { get; set; }
        public ElectronicBillDto ElectronicBill { get; set; }
        public string SubscriptionTypeName { get; set; }

        public CreateElectronicBillingRequest(string subscriptorName, string taxPercentage, Currency currency, bool isCancellation, string rut,
            string socialReason, decimal amount, ElectronicBillDto electronicBill, string SubscriptionTypeName)
        {
            SubscriptorName = subscriptorName;
            TaxPercentage = taxPercentage;
            IsCancellation = isCancellation;
            Rut = rut;
            SocialReason = socialReason;
            Amount = amount;
            ElectronicBill = electronicBill;
            Currency = currency;
            this.SubscriptionTypeName = SubscriptionTypeName;
        }
    }
}
