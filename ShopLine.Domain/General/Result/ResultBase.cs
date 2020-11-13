using System;
using System.Collections.Generic;
using System.Text;

namespace ShopLine.Domain.General
{
    public abstract class ResultBase
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public List<ValidationError> ValidationErrors { get; set; }
    }
}
