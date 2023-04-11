using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebAPI.Attributes;

namespace WebAPI.Controllers
{
    public class EmptyController : ApiController
    {
        // GET: Empty
        [BasicAuthentication]
        public string Get()
        {
            return "FatihHAS";
        }

        [BasicAuthentication]
        public List<string> Get(int id)
        {
            return new List<string>()
            {
                "RestfulAPI","HelloWorld"
            };
        }
    }
}