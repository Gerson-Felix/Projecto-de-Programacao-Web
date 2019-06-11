using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vitty.DTOS;

namespace Vitty.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //try
            //{
                var customer = (Customer)validationContext.ObjectInstance;

                if (customer.MembershipTypeId == MembershipType.Unknown ||
                    customer.MembershipTypeId == MembershipType.PayAsYouGo)
                {
                    return ValidationResult.Success;
                }

                if (customer.Birthdate == null)
                {
                    return new ValidationResult("Requer a Data de Aniversário");
                }

                var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

                return (age >= 18) ?
                    ValidationResult.Success
                    : new ValidationResult("O Cliente deve ter 18 ou superior para ter Tipo de Membro");
            //}
            //catch
            //{
            //    var customer = (CustomerDTO)validationContext.ObjectInstance;

            //    if (customer.MembershipTypeId == MembershipType.Unknown ||
            //        customer.MembershipTypeId == MembershipType.PayAsYouGo)
            //    {
            //        return ValidationResult.Success;
            //    }

            //    if (customer.Birthdate == null)
            //    {
            //        return new ValidationResult("Requer a Data de Aniversário");
            //    }

            //    var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            //    return (age >= 18) ?
            //        ValidationResult.Success
            //        : new ValidationResult("O Cliente deve ter 18 ou superior para ter Tipo de Membro");
            //}
            
        }

    }
}