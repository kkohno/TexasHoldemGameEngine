using TexasHoldem.Logic.GameMechanics;
using TexasHoldem.Logic.Players;

namespace TexasHoldem.Logic.Web;

public sealed class WebTexasHoldem: ITexasHoldemGame
{
	readonly List<WebPlayer> m_Players;
	readonly TexasHoldemGame m_Game;
	bool m_IsStarted;
	public int HandsPlayed => m_Game.HandsPlayed;

	public IReadOnlyList<WebPlayer> Players => m_Players;
	public TexasHoldemGame Game => m_Game;
	public bool IsStarted => m_IsStarted;

	public WebTexasHoldem(IEnumerable<WebPlayer> players, int initialMoney)
	{
		m_Players = players.ToList();
		m_Game = new TexasHoldemGame(new List<IPlayer>(m_Players), initialMoney);
	}
	public async Task<IPlayer> Start()
	{
		if (IsStarted) throw new InvalidOperationException("game already started");
		m_IsStarted = true;
		return await m_Game.Start();
	}
}