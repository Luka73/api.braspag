using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project.Api.Models.Validations
{
    public class ValidationValor : ValidationAttribute
    {
        public ValidationValor()
        {

        }

        public override bool IsValid(object value)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return false;
            }

            bool valido = ValidaValor(value.ToString());
            return valido;
        }

        public bool ValidaValor(string valor)
        {
            Decimal result;
 
            if (Decimal.TryParse(valor.Replace(',','.'), out result))
            {  
                result = Convert.ToDecimal(valor);

                if (result > 0)
                    return true;
            }

            return false;
        }
    }
}