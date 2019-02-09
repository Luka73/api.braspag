using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Project.Api.Models.Validations;

namespace Project.Api.Models
{
    public class TransacaoModel
    {
        [ValidationValor (ErrorMessage = "Por favor, insira um valor válido")]
        public decimal Valor { get; set; }
        [ValidationAdquirente (ErrorMessage = "Por favor, insira um adquirente válido")]
        public string Adquirente { get; set; }
        [ValidationTipo(ErrorMessage = "Por favor, insira um tipo válido")]
        public string Tipo { get; set; }
        [ValidationBandeira(ErrorMessage = "Por favor, insira uma bandeira válido")]
        public string Bandeira { get; set; }
    }
}