using Goova.Subscriptions.Models.Entities;
using Goova.Subscriptions.Models.Enumerables;

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
        public RetriesConfigurationEnum ClientRetryAttempts { get; set; }
        public string ClientId { get; set; }
        public int SubscriptorId { get; set; }
        public string ExternalId { get; set; }

        public PurchaseRequest(Instrument instrument, Currency currency, int transactionId, decimal amount, int commerceId, string taxPercentage, string plexoExtendedResponse, int subscriptionTypeId, RetriesConfigurationEnum clientRetryAttempts, string clientId, int subscriptorId, string externalId)
        {
            Instrument = instrument;
            Currency = currency;
            TransactionId = transactionId;
            Amount = amount;
            CommerceId = commerceId;
            TaxPercentage = taxPercentage;
            PlexoExtendedResponse = plexoExtendedResponse;
            SubscriptionTypeId = subscriptionTypeId;
            ClientRetryAttempts = clientRetryAttempts;
            ClientId = clientId;
            SubscriptorId = subscriptorId;
            ExternalId = externalId;
        }
    }
}
