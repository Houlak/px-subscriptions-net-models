
namespace Goova.Subscriptions.Models.Instruments
{
    public class InstrumentCallbackResponse
    {
        public bool RegisterSuccess { get; set; }
        public string ErrorString { get; set; }
        public string ExternalId { get; set; }
        public Instrument Instrument { get; set; }
    }
}
