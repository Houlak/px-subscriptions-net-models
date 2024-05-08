using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Requests.ElectronicBilling.ApiModels
{
    public class ElectronicBillResponse
    {
        public ElectronicBillingResponse ElectronicBillingResponse { get; set; }
        public CAEResponse CAE { get; set; }
    }
}
