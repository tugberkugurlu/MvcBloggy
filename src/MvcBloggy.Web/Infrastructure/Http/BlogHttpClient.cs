using MvcBloggy.API.Model.Dtos;
using MvcBloggy.Web.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MvcBloggy.Web.Infrastructure.Http {

    public class BlogHttpClient<TDto> : HttpApiClient<TDto, Guid>, IHttpApiClient<TDto, Guid> where TDto : IDto {

        private readonly string _userName;
        private readonly string _password;

        public BlogHttpClient(IApplicationSettings appSettings) : base() {

            base.BaseAddress = new Uri(appSettings.BlogApiBaseAddress);

            _userName = appSettings.BlogApiUserName;
            _password = appSettings.BlogApiPassword;
            DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", EncodeToBase64(string.Format("{0}:{1}", _userName, _password)));
        }

        private static string EncodeToBase64(string value) {

            byte[] toEncodeAsBytes = Encoding.UTF8.GetBytes(value);
            return Convert.ToBase64String(toEncodeAsBytes);
        }
    }
}