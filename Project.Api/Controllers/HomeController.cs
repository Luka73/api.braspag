using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Project.Service;
using Project.Entities;

namespace Project.Api.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        public List<MDR> mdr()
        {          
            return MockMDR.ListaMDR();
        }
    }
}
