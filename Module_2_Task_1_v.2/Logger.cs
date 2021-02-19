using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Task_1
{
    public sealed class Logger
    {
        private static readonly Logger _instance = new Logger();
        private readonly StringBuilder _log = new StringBuilder();

        static Logger()
        {
        }

        private Logger()
        {
        }

        public static Logger Instance => _instance;
        public string Log => _log.ToString();

        public void LogEventInfo(string message)
        {
            LogEvent(LogType.Info, message);
        }

        public void LogEventWarning(string message)
        {
            LogEvent(LogType.Warning, message);
        }

        public void LogEventError(string message)
        {
            LogEvent(LogType.Error, message);
        }

        public void LogEvent(LogType logType, string message)
        {
            var logMessage = $"{DateTime.UtcNow}: {logType}: {message}";

            Console.WriteLine(logMessage);
            _log.AppendLine(logMessage);
        }
    }
}
