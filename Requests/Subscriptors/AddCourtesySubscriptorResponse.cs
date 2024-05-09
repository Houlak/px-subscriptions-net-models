using Goova.Subscriptions.Models.Dtos.Subscriptions;

namespace Goova.Subscriptions.Models.Requests.Subscriptors
{
    public class AddCourtesySubscriptorResponse
    {
        public int SubscriptorId { get; set; }
        public SubscriptionDto CourtesySubscription { get; set; }
    }
}
