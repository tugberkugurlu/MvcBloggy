using MvcBloggy.API.Model.RequestModels;
using MvcBloggy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBloggy.API.Model {

    internal static class BlogPostRequestModelExtensions {

        internal static BlogPost ToBlogPost(this BlogPostRequestModel blogPostRequestModel) {

            return new BlogPost() {

                BriefInfo = blogPostRequestModel.BriefInfo,
                Content = blogPostRequestModel.Content,
                CreatedOn = blogPostRequestModel.CreatedOn,
                ImagePath = blogPostRequestModel.ImagePath,
                IsApproved = blogPostRequestModel.IsApproved,
                LanguageId = blogPostRequestModel.LanguageKey,
                Title = blogPostRequestModel.Title
            };
        }
    }
}
