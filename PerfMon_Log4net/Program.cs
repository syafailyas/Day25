using System;
using System.Diagnostics;
using log4net.Config;
using log4net;

namespace LoggingPerformanceTest
{
	class Program
	{
		private static readonly ILog log = LogManager.GetLogger(typeof(Program));

		static void Main(string[] args)
		{
			int iterations = 100000;
			XmlConfigurator.Configure(new FileInfo("log4net.config"));

			Stopwatch stopwatch = Stopwatch.StartNew();

			for (int i = 0; i < iterations; i++)
			{
				log.Info("This is a log message.");
			}

			stopwatch.Stop();
			Console.WriteLine($"log4net logging took {stopwatch.ElapsedMilliseconds}ms for {iterations} iterations.");
			Console.ReadLine();
		}
	}
}
