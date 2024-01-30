using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using MyGame;

partial class Program
{
	static void ManualCreation()
	{
		IPlayer player = new Player("player1");
		IBoard board = new Board(2);

		var loggerFactory = LoggerFactory.Create(
			b =>
			{
				b.ClearProviders();
				b.SetMinimumLevel(LogLevel.Information);
				b.AddNLog("nlog.config");
			}
		);

		ILogger<GameController> logger = loggerFactory.CreateLogger<GameController>();
		GameController game = new GameController(player, board, logger);
	}
}