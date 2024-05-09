using Goova.Subscriptions.Models.Enumerables;
using Goova.Subscriptions.Models.Models.Instruments;

namespace Goova.Subscriptions.Models.Requests.Plexo
{
    public class PurchaseRequest
    {
        public Instrument Instrument { get; set; }
        public Currency Currency { get; set; }
        public int TransactionId { get; set; }
        public decimal Amount { get; set; }
        public int CommerceId { get; set; }
        public string TaxPercentage { get; set; }
        public string PlexoExtendedResponse { get; set; }
        public int SubscriptionTypeId { get; set; }
        public RetriesConfigurationEnum RetriesConfiguration { get; set; }
        public string ClientId { get; set; }
        public int SubscriptorId { get; set; }
        public string ExternalId { get; set; }

        public PurchaseRequest(Instrument instrument, Currency currency, int transactionId, decimal amount, int commerceId, string taxPercentage, string plexoExtendedResponse,
            int subscriptionTypeId, RetriesConfigurationEnum retriesConfiguration, string clientId, int subscriptorId, string externalId)
        {
            this.Instrument = instrument;
            this.Currency = currency;
            this.TransactionId = transactionId;
            this.Amount = amount;
            this.CommerceId = commerceId;
            this.TaxPercentage = taxPercentage;
            this.PlexoExtendedResponse = plexoExtendedResponse;
            this.SubscriptionTypeId = subscriptionTypeId;
            this.RetriesConfiguration = retriesConfiguration;
            this.ClientId = clientId;
            this.SubscriptorId = subscriptorId;
            this.ExternalId = externalId;
        }
    }
}
