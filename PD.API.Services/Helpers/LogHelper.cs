using System;
using System.Diagnostics;
using System.Reflection;
using NLog;

namespace PD.API.Services.Helpers
{
    /// <summary>
    /// Performs the NLog logging for both the external and internal websites.
    /// </summary>
    public class LogHelper
    {
        #region Instantiation

        public static LogHelper BuildLogHelper(string applicationName)
        {
            var lh = new LogHelper(applicationName);
            lh.BuildApplicationVersion(Assembly.GetExecutingAssembly());
            return (lh);
        }

        public LogHelper(string applicationName)
        {
            CurrentApplicationName = applicationName;
            BuildApplicationVersion(Assembly.GetExecutingAssembly());
        }

        #endregion

        #region Properties

        public string CurrentApplicationName { get; set; }

        private string _appVersion = string.Empty;
        public string ApplicationVersion
        {
            get
            {
                if (string.IsNullOrEmpty(_appVersion))
                {
                    _appVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
                }
                return (_appVersion);
            }
        }

        public void BuildApplicationVersion(Assembly application)
        {
            _appVersion = string.Format("{0}", application.GetName().Version.ToString());
        }

        private string _userOrProcessName = string.Empty;
        public string UserOrProcessName
        {
            get
            {
                if (string.IsNullOrEmpty(_userOrProcessName))
                {
                    var windowsIdentity = System.Security.Principal.WindowsIdentity.GetCurrent();
                    _userOrProcessName = windowsIdentity != null ? windowsIdentity.Name : Process.GetCurrentProcess().ProcessName;
                }
                return (_userOrProcessName);
            }
        }

        #endregion

        #region Log Errors

        // NOTE: These are specifically NOT calling a base method to reduce unecessary information on the callstack variable in nlog.

        public void LogError(object sender, string message)
        {
            try
            {
                var loggerName = sender.GetType().FullName;
                var log = LogManager.GetLogger(loggerName);
                var theEvent = CreateLogEvent(LogLevel.Error, loggerName, message, null, string.Empty);
                log.Log(theEvent);
            }
            catch
            {
            }
        }

        public void LogError(object sender, Exception ex)
        {
            try
            {
                var loggerName = sender.GetType().FullName;
                var log = LogManager.GetLogger(loggerName);
                var theEvent = CreateLogEvent(LogLevel.Error, loggerName, string.Empty, ex, string.Empty);
                log.Log(theEvent);
            }
            catch
            {
            }
        }

        public void LogError(object sender, string message, Exception ex)
        {
            try
            {
                var loggerName = sender.GetType().FullName;
                var log = LogManager.GetLogger(loggerName);
                var theEvent = CreateLogEvent(LogLevel.Error, loggerName, message, ex, string.Empty);
                log.Log(theEvent);
            }
            catch
            {
            }
        }

        public void LogError2(NLog.Logger logger, string message, Exception ex)
        {
            try
            {
                var theEvent = CreateLogEvent(LogLevel.Error, logger.Name, message, ex, string.Empty);
                logger.Log(theEvent);
            }
            catch
            {
            }
        }

        #endregion

        #region Log Information

        // NOTE: These are specifically NOT calling a base method to reduce unecessary information on the callstack variable in nlog.

        public void LogInfo(object sender, string message)
        {
            try
            {
                var loggerName = sender.GetType().FullName;
                var log = LogManager.GetLogger(loggerName);
                var logEvent = CreateLogEvent(LogLevel.Info, loggerName, message, null, string.Empty);

                log.Log(logEvent);
            }
            catch
            {
            }
        }

        public void LogInfo(object sender, string message, string data)
        {
            try
            {
                var loggerName = sender.GetType().FullName;
                var log = LogManager.GetLogger(loggerName);
                var logEvent = CreateLogEvent(LogLevel.Info, loggerName, message, null, data);

                log.Log(logEvent);
            }
            catch
            {
            }
        }

        #endregion

        #region Log Trace

        // NOTE: These are specifically NOT calling a base method to reduce unecessary information on the callstack variable in nlog.

        public void LogTrace(object sender, string message)
        {
            try
            {
                var loggerName = sender.GetType().FullName;
                var log = LogManager.GetLogger(loggerName);
                var logEvent = CreateLogEvent(LogLevel.Trace, loggerName, message, null, string.Empty);

                log.Log(logEvent);
            }
            catch
            {
            }
        }

        public void LogTrace(object sender, string message, string data)
        {
            try
            {
                var loggerName = sender.GetType().FullName;
                var log = LogManager.GetLogger(loggerName);
                var logEvent = CreateLogEvent(LogLevel.Trace, loggerName, message, null, data);

                log.Log(logEvent);
            }
            catch
            {
            }
        }

        public void LogTrace(NLog.Logger logger, string message, string data)
        {
            try
            {
                var logEvent = CreateLogEvent(LogLevel.Trace, logger.Name, message, null, data);

                logger.Log(logEvent);
            }
            catch
            {
            }
        }

        #endregion

        #region Private Support Methods

        private LogEventInfo CreateLogEvent(NLog.LogLevel level, string loggerName, string message, Exception ex, string data)
        {
            var logEvent = new NLog.LogEventInfo(level, loggerName, message);
            if (level == LogLevel.Error && ex == null)
            {
                data += "Exception not passed.";
            }

            if (ex != null)
            {
                logEvent.Exception = ex;
            }

            logEvent.Properties["user"] = UserOrProcessName;
            logEvent.Properties["applicationVersion"] = ApplicationVersion;
            logEvent.Properties["data"] = data;
            logEvent.Properties["applicationName"] = CurrentApplicationName;

            return logEvent;
        }

        #endregion
    }
}
