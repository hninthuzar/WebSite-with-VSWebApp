using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Models
{
    public class Emails : ApiController
    {
        public string name { get; set; }

        public string email { get; set; }

        public string phoneno { get; set; }

        public string subject { get; set; }

        public string message { get; set; }

    }
}
