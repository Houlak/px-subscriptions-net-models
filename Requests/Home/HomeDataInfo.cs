using System;
using System.Collections.Generic;

namespace Goova.Subscriptions.Models.Requests.Home
{
    public class HomeDataInfo
    {
        public int TotalSubscriptors { get; set; }
        public int CourtesySubscriptors { get; set; }
        public List<(DateTime, int)> HistoricTotalSubscriptors { get; set; }
        public int ChurnSubscriptors { get; set; }
    }
}
