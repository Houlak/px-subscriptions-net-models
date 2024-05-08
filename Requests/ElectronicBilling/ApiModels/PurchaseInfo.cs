using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Requests.ElectronicBilling.ApiModels
{
    public class PurchaseInfo
    {
        public int Amount { get; set; } = 1; //Cantidad de items
        public int Currency { get; set; } = 153; //153 UYU, 150 DLR
        public BillingInd BillingInd { get; set; }
        public double UnitPrice { get; set; } //IVA inc.
        public string ProductName { get; set; }
    }

    public enum BillingInd
    {
        IVA0 = 1,
        IVA10 = 2,
        IVA22 = 3,
    }
}
