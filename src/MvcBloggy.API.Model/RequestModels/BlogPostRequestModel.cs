using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBloggy.API.Model.RequestModels {
    
    public class BlogPostRequestModel {

        [Required]
        public int LanguageKey { get; set; }

        [Required]
        [StringLength(300)]
        public string Title { get; set; }

        [StringLength(200)]
        public string BriefInfo { get; set; }

        [Required]
        public string Content { get; set; }

        [StringLength(300)]
        public string ImagePath { get; set; }

        [Required]
        public bool IsApproved { get; set; }

        [Required]
        public DateTimeOffset CreatedOn { get; set; }

        public string[] Tags { get; set; }
    }
}