using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Project.Service;
using Project.Entities;
using Project.Api.Models;
using AutoMapper;

namespace Project.Api.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        public List<MDR> mdr()
        {
            return MockMDR.ListaMDR();
        }

        [HttpPost]
        public HttpResponseMessage transaction([FromBody] TransacaoModel model)
        {
            if (ModelState.IsValid)
            {
                Transacao transacao = Mapper.Map<Transacao>(model);
                TransacaoService transacaoService = new TransacaoService();
                TotalLiquidoModel totalLiquidoModel = Mapper.Map<TotalLiquidoModel>(transacaoService.CalculaTotalLiquido(transacao));
                return Request.CreateResponse(HttpStatusCode.OK, totalLiquidoModel);
            }
            else
            {
                var listaErros = new List<string>();
                foreach (var i in ModelState.Values)
                {
                    foreach (var e in i.Errors)
                    {
                        listaErros.Add(e.ErrorMessage);
                    }
                }
                return Request.CreateResponse(HttpStatusCode.BadRequest, listaErros);
            }
        }
    }
}
