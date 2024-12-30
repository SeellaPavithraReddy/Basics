using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFApp.Models
{
    public class AgeValidation:ValidationAttribute
    {
        protected override  ValidationResult? IsValid(object? value, ValidationContext validationContext){
            DateTime val = DateTime.Parse(value.ToString());

            DateTime obj=DateTime.Parse(validationContext.ObjectType.GetProperty("Dob").GetValue(validationContext.ObjectInstance,null).ToString());
                if((val-obj).TotalDays/365<21)
            return new ValidationResult("age must be minimum 21");
            else
            {
                return ValidationResult.Success;
            }
        }
    }
}