using Goova.Subscriptions.Models.Enumerables;
using Microsoft.AspNetCore.Identity;

namespace Goova.Subscriptions.Models.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public UserType UserType { get; set; }
    }
}
