﻿using Goova.Subscriptions.Models.Dtos.Instruments;

namespace Goova.Subscriptions.Models.Requests.Instruments
{
    public class InstrumentCallbackResponse
    {
        public bool RegisterSuccess { get; set; }
        public string ErrorString { get; set; }
        public string ExternalId { get; set; }
        public InstrumentDto Instrument { get; set; }
    }
}
