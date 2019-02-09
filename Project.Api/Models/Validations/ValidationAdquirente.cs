using Project.Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project.Api.Models.Validations
{
    public class ValidationAdquirente : ValidationAttribute
    {
        public ValidationAdquirente()
        {

        }

        public override bool IsValid(object value)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return false;
            }

            bool valido = ValidaAdquirente(value.ToString());
            return valido;
        }

        public bool ValidaAdquirente(string valor)
        {
            try
            {
                Enum.Parse(typeof(Adquirente), valor, true);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}