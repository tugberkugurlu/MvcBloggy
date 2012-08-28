using MvcBloggy.API.Model.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace MvcBloggy.Web.Infrastructure.Http {
    
    public interface IHttpApiClient<TEntity, TKey> where TEntity : IDto {

        Uri BaseAddress { get; set; }

        Task<HttpApiResponseMessage<PaginatedDto<TEntity>>> GetPaginatedAsync(string path, object queryParameters);
        Task<HttpApiResponseMessage<TEntity>> GetSingleAsync(string path, TKey key);
        Task<HttpApiResponseMessage<TEntity>> GetSingleAsync(string path, TKey key, object queryParameters);

        Task<HttpApiResponseMessage<TEntity>> PostAsync<TRequestModel>(string path, TRequestModel requestModel);
        Task<HttpApiResponseMessage<TEntity>> PostAsync<TRequestModel>(string path, TRequestModel requestModel, object queryParameters);

        Task<HttpApiResponseMessage<TEntity>> PutAsync<TRequestModel>(string path, TKey key, TRequestModel requestModel);
        Task<HttpApiResponseMessage<TEntity>> PutAsync<TRequestModel>(string path, TKey key, TRequestModel requestModel, object queryParameters);

        Task<HttpApiResponseMessage> DeleteAsync(string path, TKey key);
        Task<HttpApiResponseMessage> DeleteAsync(string path, TKey key, object queryParameters);
    }
}