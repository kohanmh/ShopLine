using System;
using System.Collections.Generic;
using System.Text;

namespace ShopLine.Domain.General
{
    public class SortInfo
    {
        public string Dir { get; set; }
        public string Field { get; set; }
        public int Order { get; set; }
        public SortDirection SortDirection { get; }
    }
}
