using Goova.Subscriptions.Models.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Subscriptions
{
    public class SubscriptionCancellationNotif : Notification
    {
        public string SubscriptionType { get; set; }
        public string SubscriptionActulStatus {get; set;}
        public string ClientName { get; set; }
        public string CancellationDate { get; set; }
        public new NotificationTypeEnum NotificationType { get; } = NotificationTypeEnum.SubscriptionCancellation;

    }
}
