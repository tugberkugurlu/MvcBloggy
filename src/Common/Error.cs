using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace MvcBloggy {

    /// <summary>
    /// Utility class for creating and unwrapping <see cref="Exception"/> instances.
    /// </summary>
    internal static class Error {

        internal static string Format(string format, params object[] args) {

            return String.Format(CultureInfo.CurrentCulture, format, args);
        }

        internal static ArgumentException Argument(string messageFormat, params object[] messageArgs) {

            return new ArgumentException(Error.Format(messageFormat, messageArgs));
        }

        internal static ArgumentException ArgumentNullOrEmpty(string parameterName) {

            return Error.Argument(parameterName, CommonResources.ArgumentNullOrEmpty, parameterName);
        }

        internal static ArgumentNullException PropertyNull() {

            return new ArgumentNullException("value");
        }

        internal static ArgumentNullException ArgumentNull(string parameterName) {

            return new ArgumentNullException(parameterName);
        }

        internal static ArgumentNullException ArgumentNull(string parameterName, string messageFormat, params object[] messageArgs) {

            return new ArgumentNullException(parameterName, Error.Format(messageFormat, messageArgs));
        }
    }
}