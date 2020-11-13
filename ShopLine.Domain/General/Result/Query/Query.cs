using System;
using System.Collections.Generic;
using System.Text;

namespace ShopLine.Domain.General.Result.Query
{
    public class Query
    {
        public int Take { get; set; }
        public int Skip { get; set; }
        public int Page { get; set; }
        public bool DisableCount { get; set; }
        public bool DisablePaging { get; set; }
        public ICollection<SortInfo> Sort { get; set; }
        public Filter Filter { get; set; }
    }
    public class Query<TResult> : Query where TResult : QueryResult
    {
       // public Query();
    }
}
