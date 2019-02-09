using Project.Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project.Api.Models.Validations
{
    public class ValidationTipo : ValidationAttribute
    {
        public ValidationTipo()
        {

        }

        public override bool IsValid(object value)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return false;
            }

            bool valido = ValidaTipo(value.ToString());
            return valido;
        }

        public bool ValidaTipo(string valor)
        {
            try
            {
                Enum.Parse(typeof(TipoTransacao), valor, true);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}