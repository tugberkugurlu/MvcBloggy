using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBloggy.API.Model.Validation {

    public class MinimumAttribute : ValidationAttribute {

        private readonly int _minimumValue;

        public MinimumAttribute(int minimum) {

            _minimumValue = minimum;
        }

        public override bool IsValid(object value) {

            int intValue;
            if (value != null && int.TryParse(value.ToString(), out intValue)) {

                return (intValue >= _minimumValue);
            }

            return false;
        }
    }
}
