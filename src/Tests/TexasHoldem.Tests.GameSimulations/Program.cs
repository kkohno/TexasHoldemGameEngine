namespace TexasHoldem.Tests.GameSimulations
{
	using System;
	using System.Threading.Tasks;
	using TexasHoldem.Tests.GameSimulations.GameSimulators;

    public static class Program
	{
		public static async Task Main()
		{
			await SimulateGames(new SmartVsAlwaysCallPlayerSimulator());
			await SimulateGames(new SmartVsDummyPlayerSimulator());
			await SimulateGames(new SmartVsSmartPlayerSimulator());
			await SimulateGames(new AlwaysCallPlayersGameSimulator());
		}

		private static async Task SimulateGames(IGameSimulator gameSimulator)
		{
			Console.WriteLine($"Running {gameSimulator.GetType().Name}...");

			var simulationResult = await gameSimulator.Simulate(10000);

			Console.WriteLine(simulationResult.SimulationDuration);
			Console.WriteLine($"Total games: {simulationResult.FirstPlayerWins:0,0} - {simulationResult.SecondPlayerWins:0,0}");
			Console.WriteLine($"Hands played: {simulationResult.HandsPlayed:0,0}");
			Console.WriteLine(new string('=', 75));
		}
	}
}
