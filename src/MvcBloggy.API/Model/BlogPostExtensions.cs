using MvcBloggy.API.Model.Dtos;
using MvcBloggy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBloggy.API.Model {
    
    internal static class BlogPostExtensions {

        internal static BlogPostDto ToBlogPostDto(this BlogPost blogPost) {

            if (blogPost == null) 
                throw Error.ArgumentNull("blogPost");

            return new BlogPostDto { 

                Key = blogPost.Key,
                LanguageKey = blogPost.LanguageKey,
                SecondaryKey = blogPost.SecondaryKey,
                Title = blogPost.Title,
                BriefInfo = blogPost.BriefInfo,
                Content = blogPost.Content,
                ImagePath = blogPost.ImagePath,
                IsApproved = blogPost.IsApproved,
                CreationIp = blogPost.CreationIp,
                CreatedOn = blogPost.CreatedOn,
                LastUpdateIp = blogPost.LastUpdateIp,
                LastUpdatedOn = blogPost.LastUpdatedOn
            };
        }
    }
}