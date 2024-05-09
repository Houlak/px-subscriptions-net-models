using Goova.Subscriptions.Models.Dtos.Notifications;
using Goova.Subscriptions.Models.Enumerables;

namespace Goova.Subscriptions.Models.Requests.Subscriptions
{
    public class SubscriptionCancellationNotif : NotificationDto
    {
        public string SubscriptionType { get; set; }
        public string SubscriptionActulStatus {get; set;}
        public string ClientName { get; set; }
        public string CancellationDate { get; set; }
        public string ExternalId { get; set; } //subscriptor external id
        public new NotificationTypeEnum NotificationType { get; } = NotificationTypeEnum.SubscriptionCancellation;

    }
}
