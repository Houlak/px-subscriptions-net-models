using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Instruments
{
    public class RegisterInstrumentRequest
    {
        public bool ActiveCallback { get; set; }
        public string CallbackUrl { get; set; }
    }
}
