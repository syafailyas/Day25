using NLog;
using NLog.Config;

class Program
{
    static void Main(string[] args)
    {
        // Load the NLog configuration from a different file
        var config = new XmlLoggingConfiguration("nlog.config");
        LogManager.Configuration = config;

        // Use NLog as usual
        var logger = LogManager.GetCurrentClassLogger();
        logger.Info("Hello, world!");
    }
}
