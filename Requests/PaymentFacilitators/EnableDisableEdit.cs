﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Requests.PaymentFacilitator
{
    public class EnableDisableEdit
    {
        public string ClientId { get; set;}
        public bool Enable { get; set; }
    }
}
