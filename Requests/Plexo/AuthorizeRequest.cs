using Goova.Subscriptions.Models.Requests.Instruments;
using System;

namespace Goova.Subscriptions.Models.Requests.Plexo
{
    public class AuthorizeRequest
    {
        public Guid ClientId { get; set; }
        public string ExternalId { get; set; }
        public string RedirectUrl { get; set; }
        public string CallbackUrl { get; set; }
        public bool PopulateData { get; set; } = true;
        public int? Issuer { get; set; } = null;

        public AuthorizeRequest(Guid clientId, string externalId, string redirectUrl, string callbackUrl, bool populateData, int? issuer)
        {
            ClientId = clientId;
            ExternalId = externalId;
            RedirectUrl = redirectUrl;
            CallbackUrl = callbackUrl;
            PopulateData = populateData;
            Issuer = issuer;
        }
    }
}
