using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goova.Subscriptions.Models.Enumerables
{
    public enum TransactionStatus
    {
        Ok = 0,
        Created = 1,
        Canceled = 2,
        CancelationFailed = 3,
        Failed = 4,
    }
}
