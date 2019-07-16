using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Canal10.Models.Clients
{
    public class AddCommerceRequest
    {
        public string CommerceName { get; set; }
        public string CommerceNumber { get; set; }
        public string CommerceTerminalNumber { get; set; }
        public int IssuerId { get; set; }
    }
}
