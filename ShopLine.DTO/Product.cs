using ShopLine.Domain.General;
using ShopLine.Domain.General.Result.Query;
using System;

namespace ShopLine.DTO
{
    public class QueryProduct : Query<ListProductQueryResult> { }
    public class Product : ResultBase
    {
        public string ProductName { get; set; }
        public int Code { get; set; }
    }
    public class ListProductQueryResult : ListQueryResult<Product> { }
}
