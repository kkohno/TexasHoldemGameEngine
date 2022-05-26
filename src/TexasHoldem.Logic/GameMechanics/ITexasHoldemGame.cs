namespace TexasHoldem.Logic.GameMechanics
{
	using System.Threading.Tasks;
	using TexasHoldem.Logic.Players;

    public interface ITexasHoldemGame
    {
        int HandsPlayed { get; }

        Task<IPlayer> Start();
    }
}
