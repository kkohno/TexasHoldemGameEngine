using TexasHoldem.Logic.Players;

namespace TexasHoldem.Logic.Web
{
	public class WebPlayer: BasePlayer
	{
		public override string Name { get; }
		public override int BuyIn { get; }

		public WebPlayer(string userId, int buyIn)
		{
			Name = userId;
			BuyIn = buyIn;
		}

		public override PlayerAction PostingBlind(IPostingBlindContext context)
		{
			return PlayerAction.Fold();
		}
		public override Task<PlayerAction> GetTurn(IGetTurnContext context)
		{
			//while()
			return Task.FromResult(PlayerAction.Raise(context.MoneyLeft));
		}
	}
}