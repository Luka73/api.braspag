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
        [ValidationValor (ErrorMessage = "Por favor, insira um valor válido.")]
        public string Valor { get; set; }
        [ValidationAdquirente (ErrorMessage = "Por favor, insira um adquirente válido.")]
        public string Adquirente { get; set; }
        [ValidationTipo(ErrorMessage = "Por favor, insira um tipo válido.")]
        public string Tipo { get; set; }
        [ValidationBandeira(ErrorMessage = "Por favor, insira uma bandeira válida.")]
        public string Bandeira { get; set; }
    }
}