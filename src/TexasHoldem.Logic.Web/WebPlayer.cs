using TexasHoldem.Logic.Players;

namespace TexasHoldem.Logic.Web;

public class WebPlayer: BasePlayer
{
	PlayerAction? m_SettedAction;

	public override string Name { get; }
	public override int BuyIn { get; }
	public bool IsMyTurn { get; private set; }

	public WebPlayer(string userId, int buyIn)
	{
		Name = userId;
		BuyIn = buyIn;
	}

	public override PlayerAction PostingBlind(IPostingBlindContext context)
	{
		return PlayerAction.Fold();
	}
	public override async Task<PlayerAction> GetTurn(IGetTurnContext context)
	{
		IsMyTurn = true;
		while (m_SettedAction == null) await Task.Delay(100);
		var action = m_SettedAction;
		m_SettedAction = null;
		return action;
	}

	public void MakeTurn(PlayerAction action)
	{
		if (!IsMyTurn) throw new InvalidOperationException("can not make player turn - is not players turn");
		m_SettedAction = action;
	}
}