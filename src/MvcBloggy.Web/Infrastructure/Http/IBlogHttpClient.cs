using MvcBloggy.API.Model.Dtos;
using MvcBloggy.Web.Infrastructure.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBloggy.Web.Infrastructure.Http {

    public interface IBlogHttpClient<TDto> : IDisposable where TDto : IDto {

        Task<PaginatedDto<TDto>> GetPaginatedAsync(string path, object queryParameters);
        Task<BlogHttpResponseMessage<TDto>> GetSingleAsync(string path, Guid key);
        Task<BlogHttpResponseMessage<TDto>> GetSingleAsync(string path, Guid key, object queryParameters);

        Task<BlogHttpResponseMessage<TDto>> PostAsync<TEntity>(string path, TEntity requestModel);
        Task<BlogHttpResponseMessage<TDto>> PostAsync<TEntity>(string path, TEntity requestModel, object queryParameters);

        Task<BlogHttpResponseMessage<TDto>> PutAsync<TEntity>(string path, Guid key, TEntity requestModel);
        Task<BlogHttpResponseMessage<TDto>> PutAsync<TEntity>(string path, Guid key, TEntity requestModel, object queryParameters);

        Task<BlogHttpResponseMessage> DeleteAsync(string path, Guid key);
        Task<BlogHttpResponseMessage> DeleteAsync(string path, Guid key, object queryParameters);
    }
}