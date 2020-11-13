using System;
using System.Collections.Generic;
using System.Text;

namespace ShopLine.Domain.General
{
    public enum DataType
    {
        None = 0,
        Number = 101,
        String = 104,
        PersianDate = 107,
        Date = 108
    }
    public enum Op
    {
        Equals = 0,
        NotEquals = 1,
        GreaterThan = 2,
        LessThan = 3,
        GreaterThanOrEqual = 4,
        LessThanOrEqual = 5,
        Contains = 6,
        StartsWith = 7,
        EndsWith = 8,
        IN = 9
    }
    public enum LogicOperator
    {
        And = 0,
        Or = 1,
        None = 2
    }
    public enum SortDirection : byte
    {
        Ascending = 0,
        Descending = 1
    }
}
