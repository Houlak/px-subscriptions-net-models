using System.Collections.Generic;
using Goova.Subscriptions.Models.Dtos.Commerce;
using Goova.Subscriptions.Models.Dtos.SubscriptionType;
using Goova.Subscriptions.Models.Dtos.Subscriptors;
using Goova.Subscriptions.Models.Enumerables;
using Goova.Subscriptions.Models.Requests;
using Goova.Subscriptions.Models.Requests.PaymentFacilitator;

namespace Goova.Subscriptions.Models.Dtos.Clients
{
    public class ClientDto
    {
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public string ClientLegalName { get; set; }
        public string ClientLegalId { get; set; }
        public string RecurringPaymentUrl { get; set; }
        public ClientAdmin Admin { get; set; }
        public ICollection<SubscriptionTypeDto> SubscriptionTypes { get; set; }
        public ICollection<CommerceDto> Commerces { get; set; }
        public ICollection<SubscriptorDto> Subscriptors { get; set; }
        public bool ElectronicBillingEnabled { get; set; }
        public RetriesConfigurationEnum RetriesConfiguration { get; set; }
        public PaymentFacilitatorConfigurationDto PaymentFacilitatorConfiguration { get; set; }
    }
}
