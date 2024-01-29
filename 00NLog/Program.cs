using NLog;

namespace NLogTest
{
	public class Program
	{
		private static Logger logger = LogManager.GetCurrentClassLogger();

		static void Main()
		{
			AppDomain test = AppDomain.CurrentDomain;
			test.UnhandledException += new UnhandledExceptionEventHandler(MyHandler);
			//var currentDirectory = Directory.GetCurrentDirectory();
			//var nlogConfigPath = Path.Combine(currentDirectory, "nlog.config");
			//LogManager.LoadConfiguration(nlogConfigPath);

			logger.Info("Starting robot arm program");

			int i = 0;
			RobotArm arm = new RobotArm();
			// while (i < 10000)
			// {
			// 	arm.Connect();
			// 	arm.MoveTo(0, 0, 0);
			// 	arm.Grab();
			// 	arm.MoveTo(10, 10, 10);
			// 	arm.Release();
			arm.Disconnect();
			i++;
			//}
			throw new Exception("2");

			logger.Info("Robot arm program finished");
		}


		public static void MyHandler(object sender, UnhandledExceptionEventArgs e)
		{
			logger.Fatal("Unhandled Exception {0}",e.ExceptionObject.ToString());
		}
	}
}
