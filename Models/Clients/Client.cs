using System.Collections.Generic;
using Goova.Subscriptions.Models.Enumerables;
using Goova.Subscriptions.Models.Models.Subscriptors;
using Goova.Subscriptions.Models.Requests;
using Goova.Subscriptions.Models.Requests.PaymentFacilitator;

namespace Goova.Subscriptions.Models.Models.Clients
{
    public class Client
    {
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public string ClientLegalName { get; set; }
        public string ClientLegalId { get; set; }
        public string RecurringPaymentUrl { get; set; }
        public ClientAdmin Admin { get; set; }
        public ICollection<SubscriptionType.SubscriptionType> SubscriptionTypes { get; set; }
        public ICollection<Commerce.Commerce> Commerces { get; set; }
        public ICollection<Subscriptor> Subscriptors { get; set; }
        public bool ElectronicBillingEnabled { get; set; }
        public RetriesConfigurationEnum RetriesConfiguration { get; set; }
        public PaymentFacilitatorConfiguration PaymentFacilitatorConfiguration { get; set; }
    }
}
