using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goova.Subscriptions.Models.Enumerables
{
    public enum TransactionState
    {
        Ok = 0,
        OnHold = 1,
        Canceled = 2,
        CancelationFailed = 3,
        Failed = 4,
    }
}
