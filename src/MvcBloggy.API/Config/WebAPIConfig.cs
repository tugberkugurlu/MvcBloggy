using MvcBloggy.API.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.Controllers;
using System.Web.Http.Validation.Providers;
using MvcBloggy.API.Infrastructure.Controllers;
using WebAPIDoodle.Http;
using MvcBloggy.API.Model.RequestCommands;

namespace MvcBloggy.API.Config {
    
    public static class WebAPIConfig {

        public static void Configure(HttpConfiguration config) {

            config.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.LocalOnly;

            //Message Handlers
            config.MessageHandlers.Add(new RemoveServerHeaderMessageHandler());

            //Formatters
            var jqueryFormatter = config.Formatters.FirstOrDefault(x => x.GetType() == typeof(JQueryMvcFormUrlEncodedFormatter));
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            config.Formatters.Remove(config.Formatters.FormUrlEncodedFormatter);
            config.Formatters.Remove(jqueryFormatter);

            //Filters
            config.Filters.Add(new InvalidModelStateFilterAttribute());

            //Default Services
            config.Services.RemoveAll(typeof(System.Web.Http.Validation.ModelValidatorProvider), v => v is InvalidModelValidatorProvider);

            // From DefaultContentNegotiator class:
            // If ExcludeMatchOnTypeOnly is true then we don't match on type only which means
            // that we return null if we can't match on anything in the request. This is useful
            // for generating 406 (Not Acceptable) status codes.
            config.Services.Replace(
                typeof(IContentNegotiator),
                new DefaultContentNegotiator(excludeMatchOnTypeOnly: true)
            );

            //Binding Rules
            config.ParameterBindingRules.Add(typeof(string[]), 
                descriptor => new CatchAllRouteParameterBinding(descriptor, '/'));

            config.ParameterBindingRules.Insert(0,
                descriptor => typeof(IRequestCommand).IsAssignableFrom(descriptor.ParameterType)
                    ? new FromUriAttribute().GetBinding(descriptor) : null);
        }
    }
}