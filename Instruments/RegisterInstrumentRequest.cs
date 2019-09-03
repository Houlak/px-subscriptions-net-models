using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Instruments
{
    public class RegisterInstrumentRequest
    {
        public bool activeCallback { get; set; }
        public string callbackUrl { get; set; }
    }
}
