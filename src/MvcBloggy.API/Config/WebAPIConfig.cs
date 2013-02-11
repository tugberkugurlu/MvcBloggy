using MvcBloggy.API.Filters;
using MvcBloggy.API.Model.RequestCommands;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.ModelBinding;
using System.Web.Http.Validation;
using System.Web.Http.Validation.Providers;
using WebApiDoodle.Web.Controllers;
using WebApiDoodle.Web.ModelBinding;

namespace MvcBloggy.API.Config {
    
    public static class WebAPIConfig {

        public static void Configure(HttpConfiguration config) {

            config.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.LocalOnly;

            //Message Handlers

            //Formatters
            var jqueryFormatter = config.Formatters.FirstOrDefault(x => x.GetType() == typeof(JQueryMvcFormUrlEncodedFormatter));
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            config.Formatters.Remove(config.Formatters.FormUrlEncodedFormatter);
            config.Formatters.Remove(jqueryFormatter);

            //Filters
            config.Filters.Add(new InvalidModelStateFilterAttribute());

            //Default Services
            config.Services.RemoveAll(typeof(ModelValidatorProvider), v => v is InvalidModelValidatorProvider);
            config.Services.Replace(typeof(IHttpActionSelector), new ComplexTypeAwareActionSelector());

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