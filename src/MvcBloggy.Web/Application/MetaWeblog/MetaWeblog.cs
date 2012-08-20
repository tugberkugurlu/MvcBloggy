using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CookComputing.XmlRpc;
using MvcBloggy.Web.Application.Services;

namespace MvcBloggy.Web.Application {

    public class MetaWeblog : XmlRpcService, IMetaWeblog {

        private readonly IAuthorizationService _authorizationService;
        private readonly string language;

        public MetaWeblog(IAuthorizationService authorizationService) {

            _authorizationService = authorizationService;
            
            language = HttpContext.Current.Request.RequestContext.RouteData.Values["language"].ToString();
        }

        public string AddPost(string blogid, string username, string password, Post post, bool publish) {
            
            throw new NotImplementedException();
        }

        public bool UpdatePost(string postid, string username, string password, Post post, bool publish) {
            
            throw new NotImplementedException();
        }

        public Post GetPost(string postid, string username, string password) {

            throw new NotImplementedException();
        }

        public CategoryInfo[] GetCategories(string blogid, string username, string password) {

            throw new NotImplementedException();
        }

        public Post[] GetRecentPosts(string blogid, string username, string password, int numberOfPosts) {

            throw new NotImplementedException();
        }

        public MediaObjectInfo NewMediaObject(string blogid, string username, string password, MediaObject mediaObject) {

            throw new NotImplementedException();
        }

        public bool DeletePost(string key, string postid, string username, string password, bool publish) {

            throw new NotImplementedException();
        }

        public BlogInfo[] GetUsersBlogs(string key, string username, string password) {

            throw new NotImplementedException();
        }

        public UserInfo GetUserInfo(string key, string username, string password) {

            throw new NotImplementedException();
        }
    }
}