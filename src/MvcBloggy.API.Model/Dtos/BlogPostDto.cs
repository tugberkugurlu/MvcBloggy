using MvcBloggy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBloggy.API.Model.Dtos {

    public class BlogPostDto {

        public BlogPostDto() { }

        public BlogPostDto(BlogPost blogPost) {

            if (blogPost == null) {
                throw new ArgumentNullException("blogPost");
            }

            Key = blogPost.Key;
            LanguageKey = blogPost.LanguageKey;
            SecondaryKey = blogPost.SecondaryKey;
            Title = blogPost.Title;
            BriefInfo = blogPost.BriefInfo;
            Content = blogPost.Content;
            ImagePath = blogPost.ImagePath;
            IsApproved = blogPost.IsApproved;
            CreationIp = blogPost.CreationIp;
            CreatedOn = blogPost.CreatedOn;
            LastUpdateIp = blogPost.LastUpdateIp;
            LastUpdatedOn = blogPost.LastUpdatedOn;
        }

        public Guid Key { get; set; }
        public Guid LanguageKey { get; set; }
        public int? SecondaryKey { get; set; }
        public string Title { get; set; }
        public string BriefInfo { get; set; }
        public string Content { get; set; }
        public string ImagePath { get; set; }
        public bool IsApproved { get; set; }
        public string CreationIp { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public string LastUpdateIp { get; set; }
        public DateTimeOffset? LastUpdatedOn { get; set; }
    }
}