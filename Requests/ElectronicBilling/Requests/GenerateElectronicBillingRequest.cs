using Goova.Subscriptions.Models;

namespace Goova.Subscriptions.Models.Requests.ElectronicBilling.Requests
{
    public class GenerateElectronicBillingRequest
    {
        public string ClientName { get; set; }
        public string LegalId { get; set; }
        public string LegalName { get; set; }
        public int SubscriptorId { get; set; }
        public string SubscriptorName { get; set; }
        public string SubscriptorExternalId { get; set; }
        public int TransactionId { get; set; }
        public Currency Currency { get; set; }
        public string TaxPercentage { get; set; }

        public GenerateElectronicBillingRequest(string clientName, string legalId, string legalName, int subscriptorId, string subscriptorName, string subscriptorExternalId,
            int transactionId, Currency currency, string taxPercentage)
        {
            ClientName = clientName;
            LegalId = legalId;
            LegalName = legalName;
            SubscriptorId = subscriptorId;
            SubscriptorName = subscriptorName;
            SubscriptorExternalId = subscriptorExternalId;
            TransactionId = transactionId;
            Currency = currency;
            TaxPercentage = taxPercentage;
        }
    }
}
