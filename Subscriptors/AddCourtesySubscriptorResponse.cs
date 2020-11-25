using Goova.Subscriptions.Models.Subscriptions;

namespace Goova.Subscriptions.Models.Subscriptors
{
    public class AddCourtesySubscriptorResponse
    {
        public int SubscriptorId { get; set; }
        public Subscription CourtesySubscription { get; set; }
    }
}
