using NLog;
using System;
using System.Collections.Concurrent;
using System.Globalization;
using System.Reflection;

namespace Hexagon.ALI.Analysis.Common.Helpers
{
    //Logging.cs from the HxGN.PPMPlatform.Common. We were only use this nuGet in the past for this static logging class but the nuget has some vulnerabilities caught by Black Duck and must be removed
    public enum LogCategories
    {
        AMQP,
        Query,
        Schema,
        Config,
        Cache,
        MultiTenant,
        General,
        ClipperDrive,
        LoggingBroker,
        DBUpgrade,
        DefaultSettings,
        Anonymous,
        SignalR
    }
    internal interface ILogCustomFields
    {
        bool Write(ILogger logger);

        LogEventInfo FillLoggerEventInfo(ILogger logger);
    }
    internal class LogCustomFields : ILogCustomFields
    {
        #region Consts
        private const string MESSEGESHORT = "message_short";
        private const string SERVICENAME = "service_name";
        private const string EXCEPTIONMESSAGE = "exception_message";
        private const string EXCEPTIONSTACKTRACE = "exception_stacktrace";
        #endregion

        #region Proporties
        internal LogLevel Loglevel { get; set; }

        internal Exception Exp { get; set; }

        internal LogEventInfo EventInfo { get; set; }

        internal string StackTrace { get; set; }

        internal string Calledby { get; set; }

        internal string Messege { get; set; }

        internal string FullExpMsg
        {
            get
            {
                if (string.IsNullOrEmpty(StackTrace))
                {
                    return $"{Messege}\n{StackTrace}";
                }
                else
                {
                    return Messege;
                }
            }
        }
        #endregion

        public bool Write(ILogger logger)
        {
            bool retVal;

            try
            {
                var eventInfo = FillLoggerEventInfo(logger);
                logger.Log(eventInfo);
                retVal = true;
            }
            catch
            {
                retVal = false;
            }

            return retVal;
        }

        public LogEventInfo FillLoggerEventInfo(ILogger logger)
        {
            LogEventInfo eventInfo = new LogEventInfo(Loglevel, logger.Name, Messege);
            string serviceName = string.Empty;

            eventInfo.Properties.Add(MESSEGESHORT, Messege);

            if (!string.IsNullOrEmpty(Calledby))
            {
                serviceName = GetCallerServiceName(Calledby);
                eventInfo.Properties.Add(SERVICENAME, serviceName);
            }

            if (Exp == null)
            {
                eventInfo.Properties.Add(EXCEPTIONMESSAGE, Messege);
                if (!string.IsNullOrEmpty(StackTrace))
                {
                    eventInfo.Properties.Add(EXCEPTIONSTACKTRACE, StackTrace);
                }
            }
            else
            {
                eventInfo.Properties.Add(EXCEPTIONMESSAGE, Exp.Message);
                eventInfo.Properties.Add(EXCEPTIONSTACKTRACE, Exp.StackTrace);
                eventInfo.Exception = Exp;
            }

            return eventInfo;
        }

        private static string GetCallerServiceName(string fullname)
        {
            string[] seperator = { "," };
            string[] arr = fullname.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
            if (arr != null)
            {
                return arr[0];
            }

            return string.Empty;
        }
    }
    public class Logging
    {
        private static ConcurrentDictionary<string, Logger> mobjLoggerLookup = new ConcurrentDictionary<string, Logger>();

        #region Fatal methods

        public static void Fatal(LogCategories category, string message)
        {
            ILogger logger = GetLogger(category.ToString());

            var loggerWriter = new LogCustomFields()
            {
                Calledby = Assembly.GetCallingAssembly().FullName,
                Loglevel = LogLevel.Fatal,
                Messege = message,
            };

            if (!loggerWriter.Write(logger))
            {
                logger.Fatal(message);
            }
        }

        public static void Fatal(LogCategories category, string message, Exception ex)
        {
            ILogger logger = GetLogger(category.ToString());

            var loggerWriter = new LogCustomFields()
            {
                Calledby = Assembly.GetCallingAssembly().FullName,
                Loglevel = LogLevel.Fatal,
                Messege = message,
                Exp = ex,
            };

            if (!loggerWriter.Write(logger))
            {
                logger.Fatal(ex, message);
            }
        }

        public static void FatalFormat(LogCategories category, string message, params object[] pcolParameters)
        {
            Logger logger = GetLogger(category.ToString());

            WriteLogCustomFields(LogLevel.Fatal, string.Empty, logger, Assembly.GetCallingAssembly().FullName);
            logger.Fatal(CultureInfo.CurrentCulture, message, pcolParameters);
        }

        #endregion

        #region Errors methods

        public static void Error(Exception ex, LogCategories category)
        {
            ILogger logger = GetLogger(category.ToString());

            var loggerWriter = new LogCustomFields()
            {
                Calledby = Assembly.GetCallingAssembly().FullName,
                Loglevel = LogLevel.Error,
                Messege = string.Empty,
                Exp = ex,
            };

            if (!loggerWriter.Write(logger))
            {
                logger.Error(ex);
            }
        }

        public static void Error(LogCategories category, Exception ex, string message)
        {
            ILogger logger = GetLogger(category.ToString());

            var loggerWriter = new LogCustomFields()
            {
                Calledby = Assembly.GetCallingAssembly().FullName,
                Loglevel = LogLevel.Error,
                Messege = message,
                Exp = ex,
            };

            if (!loggerWriter.Write(logger))
            {
                logger.Error(ex, message);
            }
        }

        public static void Error(Exception ex, string message)
        {
            ILogger logger = GetLogger(LogCategories.General.ToString());

            var loggerWriter = new LogCustomFields()
            {
                Calledby = Assembly.GetCallingAssembly().FullName,
                Loglevel = LogLevel.Error,
                Messege = message,
                Exp = ex,
            };

            if (!loggerWriter.Write(logger))
            {
                logger.Error(ex, message);
            }
        }

        public static void Error(LogCategories category, string caller, string message)
        {
            ILogger logger = GetLogger(category.ToString());

            var loggerWriter = new LogCustomFields()
            {
                Calledby = caller,
                Loglevel = LogLevel.Error,
                Messege = message,
            };

            if (!loggerWriter.Write(logger))
            {
                logger.Error(loggerWriter.Messege);
            }
        }

        public static void Error(LogCategories category, string caller, string message, string stackTrace)
        {
            ILogger logger = GetLogger(category.ToString());

            var loggerWriter = new LogCustomFields()
            {
                Calledby = caller,
                Loglevel = LogLevel.Error,
                Messege = message,
                StackTrace = stackTrace,
            };

            if (!loggerWriter.Write(logger))
            {
                logger.Error(loggerWriter.FullExpMsg);
            }
        }

        #endregion

        #region Warn methods

        public static void Warn(LogCategories category, string message)
        {
            ILogger logger = GetLogger(category.ToString());

            var loggerWriter = new LogCustomFields()
            {
                Calledby = Assembly.GetCallingAssembly().FullName,
                Loglevel = LogLevel.Warn,
                Messege = message,
            };

            if (!loggerWriter.Write(logger))
            {
                logger.Warn(message);
            }
        }

        public static void Warn(LogCategories category, string message, Exception ex)
        {
            ILogger logger = GetLogger(category.ToString());

            var loggerWriter = new LogCustomFields()
            {
                Calledby = Assembly.GetCallingAssembly().FullName,
                Loglevel = LogLevel.Warn,
                Messege = message,
                Exp = ex,
            };

            if (!loggerWriter.Write(logger))
            {
                logger.Warn(ex, message);
            }
        }

        public static void WarnFormat(LogCategories category, string message, params object[] pcolParameters)
        {
            Logger logger = GetLogger(category.ToString());

            WriteLogCustomFields(LogLevel.Warn, message, logger, Assembly.GetCallingAssembly().FullName);
            logger.Warn(CultureInfo.CurrentCulture, message, pcolParameters);
        }

        public static void Warn(LogCategories category, string caller, string message)
        {
            ILogger logger = GetLogger(category.ToString());

            var loggerWriter = new LogCustomFields()
            {
                Calledby = caller,
                Loglevel = LogLevel.Warn,
                Messege = message,
            };

            if (!loggerWriter.Write(logger))
            {
                logger.Warn(message);
            }
        }

        public static void Warn(LogCategories category, string caller, string message, string stackTrace)
        {
            ILogger logger = GetLogger(category.ToString());

            var loggerWriter = new LogCustomFields()
            {
                Calledby = caller,
                Loglevel = LogLevel.Warn,
                Messege = message,
                StackTrace = stackTrace,
            };

            if (!loggerWriter.Write(logger))
            {
                string exp = GetExeptionMessage(message, stackTrace);
                logger.Warn(exp);
            }
        }
        #endregion

        #region Info methods

        public static void Info(LogCategories category, string message)
        {
            ILogger logger = GetLogger(category.ToString());

            var loggerWriter = new LogCustomFields()
            {
                Calledby = Assembly.GetCallingAssembly().FullName,
                Loglevel = LogLevel.Info,
                Messege = message,
            };

            if (!loggerWriter.Write(logger))
            {
                logger.Info(message);
            }
        }

        public static void InfoFormat(LogCategories category, string message, params object[] pcolParameters)
        {
            Logger logger = GetLogger(category.ToString());

            WriteLogCustomFields(LogLevel.Info, message, logger, Assembly.GetCallingAssembly().FullName);
            logger.Info(CultureInfo.CurrentCulture, message, pcolParameters);
        }

        public static void Info(LogCategories category, string caller, string message)
        {
            ILogger logger = GetLogger(category.ToString());

            var loggerWriter = new LogCustomFields()
            {
                Calledby = caller,
                Loglevel = LogLevel.Info,
                Messege = message,
            };

            if (!loggerWriter.Write(logger))
            {
                logger.Info(message);
            }
        }

        #endregion

        #region Debug methods
        public static void Debug(LogCategories category, string message)
        {
            ILogger logger = GetLogger(category.ToString());

            var loggerWriter = new LogCustomFields()
            {
                Calledby = Assembly.GetCallingAssembly().FullName,
                Loglevel = LogLevel.Debug,
                Messege = message,
            };

            if (!loggerWriter.Write(logger))
            {
                logger.Debug(message);
            }
        }

        public static void Debug(LogCategories category, string caller, string message)
        {
            ILogger logger = GetLogger(category.ToString());

            var loggerWriter = new LogCustomFields()
            {
                Calledby = caller,
                Loglevel = LogLevel.Debug,
                Messege = message,
            };

            if (!loggerWriter.Write(logger))
            {
                logger.Debug(message);
            }
        }

        #endregion

        #region Trace methods
        public static void Trace(LogCategories category, string message)
        {
            ILogger logger = GetLogger(category.ToString());

            var loggerWriter = new LogCustomFields()
            {
                Calledby = Assembly.GetCallingAssembly().FullName,
                Loglevel = LogLevel.Trace,
                Messege = message,
            };

            if (!loggerWriter.Write(logger))
            {
                logger.Trace(message);
            }
        }

        public static void Trace(LogCategories category, string caller, string message)
        {
            ILogger logger = GetLogger(category.ToString());

            var loggerWriter = new LogCustomFields()
            {
                Calledby = caller,
                Loglevel = LogLevel.Trace,
                Messege = message,
            };

            if (!loggerWriter.Write(logger))
            {
                logger.Trace(message);
            }
        }

        #endregion

        #region Private methods

        private static bool WriteLogCustomFields(LogLevel loglevel, string msg, Logger logger, string calledby, Exception ex = null)
        {
            try
            {
                var eventInfo = new LogEventInfo(loglevel, logger.Name, msg);
                string serviceName = string.Empty;

                eventInfo.Properties.Add("message_short", msg);

                if (!string.IsNullOrEmpty(calledby))
                {
                    serviceName = GetCallerServiceName(calledby);
                    eventInfo.Properties.Add("service_name", serviceName);
                }

                if (ex != null)
                {
                    eventInfo.Properties.Add("exception_message", ex.Message);
                    eventInfo.Properties.Add("exception_stacktrace", ex.StackTrace);
                }

                logger.Log(eventInfo);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static string GetCallerServiceName(string fullname)
        {
            string[] seperator = { "," };
            string[] arr = fullname.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
            if (arr != null)
            {
                return arr[0];
            }

            return string.Empty;
        }

        private static Logger GetLogger(string name)
        {
            return mobjLoggerLookup.GetOrAdd(name, LogManager.GetLogger(name));
        }

        private static string GetExeptionMessage(string message, string stackTrace)
        {
            return $"{message}\n{stackTrace}";
        }
        #endregion
    }
}


