using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Hosting;
using System.Web.Http.Tracing;

namespace MvcBloggy.API.Tracers {

    public class NLogTracer : ITraceWriter {

        private static Lazy<Dictionary<TraceLevel, Action<string>>> _loggingMap = new Lazy<Dictionary<TraceLevel, Action<string>>>(() => new Dictionary<TraceLevel, Action<string>> { 
            {TraceLevel.Info, LogManager.GetCurrentClassLogger().Info},
            {TraceLevel.Debug, LogManager.GetCurrentClassLogger().Debug},
            {TraceLevel.Error, LogManager.GetCurrentClassLogger().Error},
            {TraceLevel.Fatal, LogManager.GetCurrentClassLogger().Fatal},
            {TraceLevel.Warn, LogManager.GetCurrentClassLogger().Warn}
        });

        private Dictionary<TraceLevel, Action<string>> _logger {
            get {
                return _loggingMap.Value;
            }
        }

        public void Trace(HttpRequestMessage request, string category, TraceLevel level, Action<TraceRecord> traceAction) {

            if (level != TraceLevel.Off) {
                TraceRecord record = new TraceRecord(request, category, level);
                traceAction(record);
                Log(record);
            }
        }

        private void Log(TraceRecord record) {

            var logMessage = CreateLogMessage(record);
            _logger[record.Level](logMessage);
        }

        private string CreateLogMessage(TraceRecord traceRecord) {

            var method = (traceRecord.Request) != null
                ? traceRecord.Request.Method.ToString()
                : null;

            var requestUri = (traceRecord.Request) != null
                ? traceRecord.Request.RequestUri.ToString()
                : null;

            var correlationId = (traceRecord.Request) != null
                ? traceRecord.Request.Properties[HttpPropertyKeys.RequestCorrelationKey]
                : null;

            return string.Format(
                "{0}|{1} {2}: Category={3}, Level={4} {5} {6} {7} {8}",
                correlationId,
                method,
                requestUri,
                traceRecord.Category,
                traceRecord.Level,
                traceRecord.Kind,
                traceRecord.Operator,
                traceRecord.Operation,
                traceRecord.Exception != null
                    ? string.Format("{0}: {1}", traceRecord.Exception.GetBaseException().GetType(), traceRecord.Exception.GetBaseException().Message)
                    : !string.IsNullOrEmpty(traceRecord.Message)
                        ? traceRecord.Message
                        : string.Empty
            );
        }
    }
}