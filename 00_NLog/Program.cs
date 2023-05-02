using System;
using NLog;

namespace NLogExample
{
    class Program
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            logger.Info("Program started.");

            int x = 5;
            int y = 10;
            int result = x * y;

            logger.Info($"The result of the calculation is: {result}");

            logger.Info("Program finished.");
        }
    }
}
