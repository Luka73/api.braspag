using Project.Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project.Api.Models.Validations
{
    public class ValidationBandeira : ValidationAttribute
    {
        public ValidationBandeira()
        {

        }

        public override bool IsValid(object value)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return false;
            }

            bool valido = ValidaBandeira(value.ToString());
            return valido;
        }

        public bool ValidaBandeira(string valor)
        {
            try
            {
                Enum.Parse(typeof(Bandeira), valor, true);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}