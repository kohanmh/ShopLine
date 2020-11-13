using System;
using System.Collections.Generic;
using System.Text;

namespace ShopLine.Domain.General
{
    public class InnerFilter
    {
        public int GroupId { get; set; }
        public DataType DataType { get; set; }
        public string ParameterName { get; set; }
        public string Field { get; set; }
        public string Operator { get; set; }
        public Op Operation { get; }
        public object Value { get; set; }

       // public Op GetOperator();
    }
}
