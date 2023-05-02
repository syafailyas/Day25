using System;
using log4net;
using log4net.Config;

namespace Log4NetExample
{
	class Program
	{
		private static readonly ILog log = LogManager.GetLogger(typeof(Program));
		private static readonly int ITERATIONS = 1000000;

		static void Main(string[] args)
		{
			XmlConfigurator.Configure(new FileInfo("App.config"));

			log.Info("Starting performance test...");

			// Start the timer
			var watch = System.Diagnostics.Stopwatch.StartNew();

			// Run the performance test
			for (int i = 0; i < ITERATIONS; i++)
			{
				// Perform some operation
				var result = i * i;
			}

			// Stop the timer
			watch.Stop();

			log.Info($"Performance test completed in {watch.ElapsedMilliseconds} ms for {ITERATIONS} iterations.");
		}
	}
}
