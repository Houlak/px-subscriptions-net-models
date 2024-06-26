﻿using Goova.Subscriptions.Models.Enumerables;
using Goova.Subscriptions.Models.Requests;
using Goova.Subscriptions.Models.Requests.PaymentFacilitator;

namespace Goova.Subscriptions.Models.Dtos.Account
{
    public class AccountDto
    {
        public string UserId { get; set; }
        public UserType UserType { get; set; }
        public ClientAccountDto ClientDetails { get; set; }
        public PaymentFacilitatorDetails PaymentFacilitatorDetails { get; set; }
    }
}
