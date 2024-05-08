using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Requests.ElectronicBilling.ApiModels
{
    public class Receiver //Cliente final
    {
        public DocType DocType { get; set; } = DocType.Unknown; //Hardcoded 4
        public string DocNumber { get; set; }
        public string SocialReason { get; set; } //If CI reciever, name of person
        public string AdditionalInfo { get; set; } //In case no info from reciever, something to identify transaction or client
    }
}
