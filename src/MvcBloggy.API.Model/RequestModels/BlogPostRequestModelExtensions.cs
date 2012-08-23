using MvcBloggy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBloggy.API.Model.RequestModels {

    public static class BlogPostRequestModelExtensions {

        public static BlogPost ToBlogPost(this BlogPostRequestModel blogPostRequestModel) {

            return new BlogPost() {
                BriefInfo = blogPostRequestModel.BriefInfo,
                Content = blogPostRequestModel.Content,
                CreatedOn = blogPostRequestModel.CreatedOn,
                ImagePath = blogPostRequestModel.ImagePath,
                IsApproved = blogPostRequestModel.IsApproved,
                LanguageKey = blogPostRequestModel.LanguageKey,
                Title = blogPostRequestModel.Title
            };
        }
    }
}