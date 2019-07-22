using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Clients
{
    public class Commerce
    {
        public int CommerceId { get; set; }
        public string Name { get; set; }
        public string CommerceNumber { get; set; }
        public string CommerceTerminalNumber { get; set; }
        public Issuer Issuer { get; set; }
    }
}
