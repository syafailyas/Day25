using System;
using System.Diagnostics;

namespace LoggingPerformanceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int iterations = 100000;
            Stopwatch stopwatch = Stopwatch.StartNew();

            for (int i = 0; i < iterations; i++)
            {
                Trace.WriteLine("This is a log message.");
            }

            stopwatch.Stop();
            Console.WriteLine($"System.Diagnostics logging took {stopwatch.ElapsedMilliseconds}ms for {iterations} iterations.");
            Console.ReadLine();
        }
    }
}
