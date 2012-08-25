using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace MvcBloggy.Web.Infrastructure.Http {

    public class BlogHttpResponseMessage<T> : BlogHttpResponseMessage {

        public BlogHttpResponseMessage(HttpResponseMessage response) 
            : base(response) { 
        }

        public BlogHttpResponseMessage(HttpResponseMessage response, T model) :
            base(response) {

            Model = model;
        }

        public T Model { get; private set; }
    }
}