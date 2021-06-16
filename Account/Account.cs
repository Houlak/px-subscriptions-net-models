using Goova.Subscriptions.Models.Clients;
using Goova.Subscriptions.Models.PaymentFacilitator;
using System;
using System.Collections.Generic;

namespace Goova.Subscriptions.Models.Account
{
    public class Account
    {
        public string UserId { get; set; }
        public UserType UserType { get; set; }
        public ClientAccountDto ClientDetails {get;set;}
        public bool ElectronicBillingEnabled { get; set; }
        public PaymentFacilitatorDetails PaymentFacilitatorDetails { get; set; }
    }
}
