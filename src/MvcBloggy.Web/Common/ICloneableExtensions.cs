using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcBloggy.Web {

    internal static class ICloneableExtensions {

        internal static T Clone<T>(this T value) where T : ICloneable {

            return (T)value.Clone();
        }
    }
}