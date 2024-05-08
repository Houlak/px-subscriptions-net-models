using Goova.Subscriptions.Models.Enumerables;

namespace Goova.Subscriptions.Models.Requests
{
    public class RegistrationRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }
    }
}
