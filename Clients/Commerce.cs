using Goova.Subscriptions.Models.Issuers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Clients
{
    public class Commerce
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CommerceNumber { get; set; }
        public string CommerceTerminalNumber { get; set; }
        public IssuerResponse Issuer { get; set; }
    }
}
