using System;
using System.Text;
using log4net;

namespace Rock.Logging
{

    public class Logger : ILogger
    {
        private readonly ILog _log;
        private StringBuilder _strLog = new StringBuilder();
        public StringBuilder Log
        {
            get { return _strLog; }
            set { _strLog = value; }
        }

        public Logger(Type logClass)
        {
            _log = LogManager.GetLogger(logClass);
        }

        public void Error(string info, Exception exception)
        {
            _log.Error(info,exception);
            _strLog.AppendLine(string.Format("{0},{1}", info, exception.Message));
        }

        public void InfoFormat(string format, params object[] args)
        {
            _log.InfoFormat(format, args);
            _strLog.AppendLine(string.Format(format, args));
        }

        public void Info(string info)
        {
            _log.Info( info);
            _strLog.AppendLine(info);
        }
    }
}
