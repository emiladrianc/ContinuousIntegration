using System;

namespace Accenture.ContinuousIntegration.Logger
{
    public interface ILogger
    {
        void Debug(string message);

        void DebugFormat(string format, params object[] args);

        void Info(string message);

        void InfoFormat(string format, params object[] args);

        void Warn(string message);

        void WarnFormat(string format, params object[] args);

        void Error(string message);

        void Error(string message, Exception exception);

    }

}
