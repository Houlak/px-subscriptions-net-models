using Goova.Subscriptions.Models.Enumerables;

namespace Goova.Subscriptions.Models.Requests
{
    public class UpdateClientSecretRequest
    {
        public string UserId { get; set; }
        public string ClientSecret { get; set; }
        public string ClientId { get; set; }
        public UserType UserType { get; set; }
    }
}
