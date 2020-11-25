using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.PagedResults
{
    public class PagedResult<T> : PagedResultBase
    {
        public IList<T> Results { get; set; }

        public PagedResult()
        {
            Results = new List<T>();
        }
    }
}
