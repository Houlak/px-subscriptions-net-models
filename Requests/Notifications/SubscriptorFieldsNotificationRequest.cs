using Plexo.Models;

namespace Goova.Subscriptions.Models.Requests.Notifications
{
    public class SubscriptorFieldsNotificationRequest
    {
        public string ClientId { get; set; }
        public int SubscriptorId { get; set; }
        public Transaction PlexoTransactionResponse { get; set; }

        public SubscriptorFieldsNotificationRequest(string clientId, int subscriptorId, Transaction plexoTransactionResponse)
        {
            ClientId = clientId;
            SubscriptorId = subscriptorId;
            PlexoTransactionResponse = plexoTransactionResponse;
        }
    }
}
