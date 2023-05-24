using DotNetNuke.Web.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace DAFF.Modules.Dnn.DAFF.ReceptValaszto.Controllers.Api
{
    public class ReceptApiController : DnnApiController
    {
        [AllowAnonymous]
        [HttpGet]
        public HttpResponseMessage ReceptKezd()
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}