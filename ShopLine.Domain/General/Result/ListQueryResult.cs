using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopLine.Domain.General
{
    public class ListQueryResult<T> : QueryResult
    {
        public ICollection<T> Entities { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public int TotalPages { get; }
        public bool HasPreviousPage { get; }
        public bool HasNextPage { get; }

       // public void ToPagedList(IQueryable<T> source, int pageIndex, int pageSize);
    }
}
