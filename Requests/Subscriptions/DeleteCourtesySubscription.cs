namespace Goova.Subscriptions.Models.Requests.Subscriptions
{
    public class DeleteCourtesySubscription
    {
        public string ExternalId { get; set; }
        public int SubscriptionTypeId { get; set; }
    }
}
