using System;
using System.Collections.Generic;
using System.Text;

namespace ShopLine.Domain.General
{
    public class Filter
    {
        public readonly IDictionary<string, string> Operators;
        public string Logic { get; set; }
        public LogicOperator LogicOperator { get; }
        public List<InnerFilter> Filters { get; set; }
       // public LogicOperator GetLogicOperator();
       // public override string ToString();
        //public string ToString<T>();
    }
}