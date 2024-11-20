namespace Goova.Subscriptions.Models.Subscriptions
{
    public class SubscriptionCancellationNotif
    {
        public string SubscriptionType { get; set; }
        public string SubscriptionActulStatus {get; set;}
        public string ClientName { get; set; }
        public string CancellationDate { get; set; }
        public string ExternalId { get; set; } //subscriptor external id
    }
}
