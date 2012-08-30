using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace MvcBloggy.API.Client.Http {
    
    public class HttpApiResponseMessage<T> : HttpApiResponseMessage {

        public HttpApiResponseMessage(HttpResponseMessage response) 
            : base(response) { 
        }

        public HttpApiResponseMessage(HttpResponseMessage response, T model) :
            base(response) {

            Model = model;
        }

        public T Model { get; private set; }
    }
}