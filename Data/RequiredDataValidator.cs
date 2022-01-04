
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace StudentsDetails.Data
{
    public class RequiredDataValidator : ValidationAttribute
    {

        public int min = 2;
        public int max = 16;
        public Boolean loop = true;

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string name = value.ToString();
            if (name.Length > 0)
            {
                foreach (char ch in name)
                {
                    loop = false;
                    if (!loop)
                    {
                        if ((ch > 65 && ch < 90) || (ch > 97 && ch < 122) || ch == 44)
                        {
                            loop = true;
                        }
                    }
                }
                if (name.Length >= min && name.Length <= max)
                {
                    return null;
                }

            }
            return new ValidationResult(ErrorMessage, new[] { validationContext.MemberName });
        }



    }
}

