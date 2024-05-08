using Goova.Subscriptions.Models.Enumerables;
using Goova.Subscriptions.Models.Models.Notifications;

namespace Goova.Subscriptions.Models.Requests.Subscriptions
{
    public class SubscriptionCancellationNotif : Notification
    {
        public string SubscriptionType { get; set; }
        public string SubscriptionActulStatus {get; set;}
        public string ClientName { get; set; }
        public string CancellationDate { get; set; }
        public string ExternalId { get; set; } //subscriptor external id
        public new NotificationTypeEnum NotificationType { get; } = NotificationTypeEnum.SubscriptionCancellation;

    }
}
