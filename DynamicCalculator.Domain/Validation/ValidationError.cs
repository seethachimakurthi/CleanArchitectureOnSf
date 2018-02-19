using System;
using System.Collections.Generic;
using System.Text;

namespace Yajat.Digitalizer.DynamicCalculator.Domain.Validations
{
    public class ValidationError
    {
        public string PropertyName { get; set; }
        public string ErrorMessage { get; set; }
    }
}
