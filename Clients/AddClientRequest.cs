using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Canal10.Models.Clients
{
    public class AddClientRequest
    {
        public ClientAdmin Admin { get; set; }
        public string ClientName { get; set; }
        public string ClientSecret { get; set; }
    }
}
