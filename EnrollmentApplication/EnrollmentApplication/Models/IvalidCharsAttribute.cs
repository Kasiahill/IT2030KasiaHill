﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnrollmentApplication.Models
{
    public class InvalidCharsAttribute : ValidationAttribute
    {
        private readonly string _invalidChar;
        public InvalidCharsAttribute(string invalidChar)
            : base("{0} contains unacceptable characters!")
        {
            _invalidChar = invalidChar;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                foreach (char item in value.ToString().ToCharArray())
                {
                    if (item.ToString().Contains(_invalidChar))
                    {
                        string errorMessage = FormatErrorMessage(validationContext.DisplayName);

                        return new ValidationResult(errorMessage);
                    }
                }
            }

            return ValidationResult.Success;
        }
    }
}
}