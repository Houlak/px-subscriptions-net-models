using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Clients
{
    public class AddClientRequest
    {
        public ClientAdmin Admin { get; set; }
        public string ClientName { get; set; }
        public string ClientSecret { get; set; }
    }
}
