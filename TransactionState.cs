using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models
{
    public enum TransactionState
    {
        Ok = 0,
        Created = 1,
        OnHold = 2,
        Error = 5,
        IssuerNotSupported = 7,
    }
}
