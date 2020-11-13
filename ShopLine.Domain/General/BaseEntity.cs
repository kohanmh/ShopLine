using System;
using System.Collections.Generic;
using System.Text;

namespace ShopLine.Domain
{
    public abstract class BaseEntity
    {
        []
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}
