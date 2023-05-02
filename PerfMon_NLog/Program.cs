using System;
using System.Diagnostics;
using NLog;

namespace LoggingPerformanceTest
{
    class Program
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            int iterations = 100000;

            Stopwatch stopwatch = Stopwatch.StartNew();

            for (int i = 0; i < iterations; i++)
            {
                logger.Info("This is a log message.");
            }

            stopwatch.Stop();
            Console.WriteLine($"NLog logging took {stopwatch.ElapsedMilliseconds}ms for {iterations} iterations.");
            Console.ReadLine();
        }
    }
}
