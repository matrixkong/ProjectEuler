using System;
using System.Text;

namespace Rock.Logging
{    
    /// <summary>
    /// Logger with a StringBuffer can output a string contains all the logged details
    /// </summary>
    public interface ILogger
    {
        StringBuilder Log { get; set; } //add stringbuilder to get a string version of log info
        void Error(string info, Exception exception);
        void InfoFormat(string format, params object[] args);
        void Info(string info);
    }
}
