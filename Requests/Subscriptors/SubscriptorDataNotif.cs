using Goova.Subscriptions.Models.Enumerables;
using Goova.Subscriptions.Models.Models.Notifications;
using System.Collections.Generic;

namespace Goova.Subscriptions.Models.Requests.Subscriptors
{
    public class SubscriptorDataNotif : Notification
    {
        public string ExternalId { get; set; }

        public Dictionary<string, string> Fields { get; set; }
        public new NotificationTypeEnum NotificationType { get; } = NotificationTypeEnum.SubscriptorData;
    }
}
