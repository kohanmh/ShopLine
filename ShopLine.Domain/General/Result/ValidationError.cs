using System;
using System.Collections.Generic;
using System.Text;

namespace ShopLine.Domain.General
{
    public class ValidationError
    {
        public string PropertyName { get; set; }
        public object PropertyValue { get; set; }
        public string ErrorMessage { get; set; }
    }
}
