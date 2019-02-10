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
    [RoutePrefix("api/home")]
    public class HomeController : ApiController
    {
        [HttpGet]
        [Route("mdr")]
        public List<MDR> Mdr()
        {
            return MockMDR.ListaMDR();
        }

        [HttpPost]
        [Route("transaction")]
        public HttpResponseMessage Transaction([FromBody] TransacaoModel model)
        {
            if (ModelState.IsValid)
            {
                if(model == null)
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "Nenhum dado requisitado");

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
