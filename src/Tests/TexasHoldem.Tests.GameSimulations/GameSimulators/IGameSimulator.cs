namespace TexasHoldem.Tests.GameSimulations.GameSimulators
{
	using System.Threading.Tasks;

    public interface IGameSimulator
    {
	    Task<GameSimulationResult> Simulate(int numberOfGames);
    }
}
