using log4net;
using log4net.Config;
using System;

namespace Accenture.ContinuousIntegration.Logger
{
    public class Logger : ILogger
    {
        private readonly ILog _log;

        public Logger()
        {
            _log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            XmlConfigurator.Configure();
        }

        public void Debug(string message)
        {
            _log.Debug(message);
        }

        public void DebugFormat(string format, params object[] args)
        {
            _log.DebugFormat(format, args);
        }

        public void Info(string message)
        {
            _log.Info(message);
        }

        public void InfoFormat(string format, params object[] args)
        {
            _log.InfoFormat(format, args);
        }

        public void Warn(string message)
        {
            _log.Warn(message);
        }

        public void WarnFormat(string format, params object[] args)
        {
            _log.WarnFormat(format, args);
        }

        public void Error(string message)
        {
            _log.Error(message);
        }

        public void Error(string message, Exception exception)
        {
            _log.Error(message, exception);
        }

    }
}
