using System;
using System.Collections.Generic;

namespace Goova.Subscriptions.Models.Home
{
    public class HomeDataInfo
    {
        public int TotalSubscriptors { get; set; }
        public int CourtesySubscriptors { get; set; }
        public List<(DateTime, int)> HistoricTotalSubscriptors { get; set; }
    }
}
