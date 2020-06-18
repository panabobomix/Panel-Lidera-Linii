using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using NLog.Web;

namespace Panel_Lidera_Linii.Helper
{
    public abstract class LoggerBase
    {
        protected static readonly Logger Logger =  NLogBuilder.ConfigureNLog("NLog.config").GetCurrentClassLogger();
    }
}
