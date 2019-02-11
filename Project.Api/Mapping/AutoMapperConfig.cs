using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.Entities;
using Project.Api.Models;
using AutoMapper;

namespace Project.Api.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<TransacaoModel, Transacao>()
                .ForMember<Decimal>(x => x.Valor, x => x.MapFrom<string>(y => y.Valor.Replace('.',',')));
            CreateMap<TotalLiquido, TotalLiquidoModel>();
        }
    }
}