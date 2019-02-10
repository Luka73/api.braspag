using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Project.Api.Models.Validations;
using System.ComponentModel.DataAnnotations;

namespace Project.Api.Models
{
    
    public class TransacaoModel
    { 
        [Required (ErrorMessage = "Por favor, digite o valor.")]
        [ValidationValor (ErrorMessage = "Por favor, insira um valor válido.")]
        public decimal Valor { get; set; }
        [Required (ErrorMessage = "Por favor, digite o adquirente.")]
        [ValidationAdquirente (ErrorMessage = "Por favor, insira um adquirente válido.")]
        public string Adquirente { get; set; }
        [Required (ErrorMessage = "Por favor, digite o tipo.")]
        [ValidationTipo(ErrorMessage = "Por favor, insira um tipo válido.")]
        public string Tipo { get; set; }
        [Required (ErrorMessage = "Por favor, digite a bandeira.")]
        [ValidationBandeira(ErrorMessage = "Por favor, insira uma bandeira válida.")]
        public string Bandeira { get; set; }
    }
}