using System.Collections.Generic;

namespace MvcBloggy.Data {

    public static class TagHelper {

        public static ICollection<DataAccess.SqlServer.Model.Tag> CreateListFromString(string tags) {

            var tagList = new List<DataAccess.SqlServer.Model.Tag>();

            if (!string.IsNullOrEmpty(tags)) {
                var _tags = tags.Split(";".ToCharArray());

                foreach (var tag in _tags) {
                    tagList.Add(new DataAccess.SqlServer.Model.Tag { 
                        TagName = tag,
                        Count = 1
                    });
                }
            }

            return tagList;
        }

        public static ICollection<string> CreateStringListFromString(string tags) {

            var tagList = new List<string>();

            if (!string.IsNullOrEmpty(tags)) {
                var _tags = tags.Split(";".ToCharArray());

                foreach (var tag in _tags) {
                    if (!string.IsNullOrEmpty(tag) && tag != " ") {
                        tagList.Add(tag);
                    }
                }
            }

            return tagList;
        }

        public static string ResolveTagsFromList(ICollection<DataAccess.SqlServer.Model.Tag> tags) {

            string _tags = string.Empty;

            foreach (var item in tags) {

                if (!string.IsNullOrEmpty(item.TagName) && item.TagName != " ") {
                    _tags += item.TagName;
                    _tags += ";";
                }
            }

            _tags = _tags.TrimEnd(char.Parse(";"));

            return _tags;
        }

        public static string ResolveTagsFromList(ICollection<string> tags) {

            string _tags = string.Empty;

            foreach (var tag in tags) {
                if (!string.IsNullOrEmpty(tag) && tag != " ") {
                    _tags += tag;
                    _tags += ";";
                }
            }

            _tags = _tags.TrimEnd(char.Parse(";"));

            return _tags;
        }

        public static string ResolveTagsFromList(string[] tags) {

            string _tags = string.Empty;

            for (int i = 0; i < tags.Length; i++) {

                if (!string.IsNullOrEmpty(tags[i]) && tags[i] != " ") {
                    _tags += tags[i];
                    _tags += ";";
                }
            }

            _tags = _tags.TrimEnd(char.Parse(";"));

            return _tags;
        }

    }
}