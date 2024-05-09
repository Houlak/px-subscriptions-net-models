using Goova.Subscriptions.Models.Dtos.Notifications;
using Goova.Subscriptions.Models.Enumerables;
using System.Collections.Generic;

namespace Goova.Subscriptions.Models.Requests.Subscriptors
{
    public class SubscriptorDataNotif : NotificationDto
    {
        public string ExternalId { get; set; }

        public Dictionary<string, string> Fields { get; set; }
        public new NotificationTypeEnum NotificationType { get; } = NotificationTypeEnum.SubscriptorData;
    }
}
