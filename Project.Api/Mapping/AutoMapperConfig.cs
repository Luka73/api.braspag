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
            CreateMap<TransacaoModel, Transacao>();
            CreateMap<TotalLiquido, TotalLiquidoModel>();
        }
    }
}