using Goova.Subscriptions.Models.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Subscriptors
{
    public class SubscriptorDataNotif : Notification
    {
        public string ExternalId { get; set; }

        public Dictionary<string, string> Fields { get; set; }
        public new NotificationTypeEnum NotificationType { get; } = NotificationTypeEnum.SubscriptorData;
    }
}
