using Goova.Subscriptions.Models.Models.Subscriptions;

namespace Goova.Subscriptions.Models.Requests.Subscriptors
{
    public class AddCourtesySubscriptorResponse
    {
        public int SubscriptorId { get; set; }
        public Subscription CourtesySubscription { get; set; }
    }
}
