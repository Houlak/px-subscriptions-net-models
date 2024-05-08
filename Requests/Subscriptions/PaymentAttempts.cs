using Goova.Subscriptions.Models.Models.Notifications;

namespace Goova.Subscriptions.Models.Requests.Subscriptions
{
    public class PaymentAttempts : Notification
    {
        public int TimesAttempted { get; set; }
        public string ExternalId { get; set; }
        public int SubscriptionTypeId { get; set; }

        public string SubscriptionTypeName { get; set; }
        
        
    }
}
