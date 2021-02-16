using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Instruments
{
    public class RegisterInstrumentRequest
    {
        public string CallbackUrl { get; set; }
        public bool PopulateData { get; set; } = true;
        public int? Issuer { get; set; } = null;
    }
}
