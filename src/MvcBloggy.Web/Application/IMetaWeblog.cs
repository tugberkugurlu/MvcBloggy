using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using CookComputing.XmlRpc;

namespace MvcBloggy.Web.Application {

    public interface IMetaWeblog {

        [XmlRpcMethod("metaWeblog.newPost")]
        string AddPost(string blogid, string username, string password, Post post, bool publish);

        [XmlRpcMethod("metaWeblog.editPost")]
        bool UpdatePost(string postid, string username, string password, Post post, bool publish);

        [XmlRpcMethod("metaWeblog.getPost")]
        Post GetPost(string postid, string username, string password);

        [XmlRpcMethod("metaWeblog.getCategories")]
        CategoryInfo[] GetCategories(string blogid, string username, string password);

        [XmlRpcMethod("metaWeblog.getRecentPosts")]
        Post[] GetRecentPosts(string blogid, string username, string password, int numberOfPosts);

        [XmlRpcMethod("metaWeblog.newMediaObject")]
        MediaObjectInfo NewMediaObject(string blogid, string username, string password,
            MediaObject mediaObject);

        [XmlRpcMethod("blogger.deletePost")]
        [return: XmlRpcReturnValue(Description = "Returns true.")]
        bool DeletePost(string key, string postid, string username, string password, bool publish);

        [XmlRpcMethod("blogger.getUsersBlogs")]
        BlogInfo[] GetUsersBlogs(string key, string username, string password);

        [XmlRpcMethod("blogger.getUserInfo")]
        UserInfo GetUserInfo(string key, string username, string password);
    }
}