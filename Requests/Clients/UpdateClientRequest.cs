using Goova.Subscriptions.Models.Enumerables;

namespace Goova.Subscriptions.Models.Requests
{
    public class UpdateClientRequest
    {
        public string ClientName { get; set; }
        public string RecurringPaymentUrl { get; set; }
        public string LegalName { get; set; }
        public bool ElectronicBillingEnabled { get; set; }
        public RetriesConfigurationEnum RetriesConfiguration { get; set; }
        public int PaymentFacilitatorCommerceId { get; set; }
        public bool CanCreateAdditionalIssuers { get; set; }
    }
}
