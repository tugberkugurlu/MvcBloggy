using MvcBloggy.API.Model.Dtos;
using MvcBloggy.Web.Application.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBloggy.Web.Application.Http {

    public interface IBlogHttpClient<T> : IDisposable {
        
        Task<PaginatedDto<T>> GetPaginatedAsync(string path, object queryParameters);
        Task<BlogHttpResponseMessage<T>> GetSingleAsync(string path, Guid key);
        Task<BlogHttpResponseMessage<T>> GetSingleAsync(string path, Guid key, object queryParameters);

        Task<BlogHttpResponseMessage<T>> PostAsync<TEntity>(string path, TEntity requestModel);
        Task<BlogHttpResponseMessage<T>> PostAsync<TEntity>(string path, TEntity requestModel, object queryParameters);

        Task<BlogHttpResponseMessage<T>> PutAsync<TEntity>(string path, Guid key, TEntity requestModel);
        Task<BlogHttpResponseMessage<T>> PutAsync<TEntity>(string path, Guid key, TEntity requestModel, object queryParameters);

        Task<BlogHttpResponseMessage> DeleteAsync(string path, Guid key);
        Task<BlogHttpResponseMessage> DeleteAsync(string path, Guid key, object queryParameters);
    }
}