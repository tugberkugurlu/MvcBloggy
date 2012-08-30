using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace MvcBloggy.API.Client.Http {
    
    public class HttpApiResponseMessage {

        public HttpApiResponseMessage(HttpResponseMessage response) {
            Response = response;
        }

        public HttpResponseMessage Response { get; private set; }
    }
}