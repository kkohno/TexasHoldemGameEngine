using System.Threading.Tasks;

namespace TexasHoldem.AI.DummyPlayer
{
    using System;

    using TexasHoldem.Logic.Players;

    internal class AlwaysRaiseDummyPlayer : BasePlayer
    {
        public override string Name { get; } = "AlwaysRaiseDummyPlayer_" + Guid.NewGuid();

        public override int BuyIn { get; } = -1;

        public override PlayerAction PostingBlind(IPostingBlindContext context)
        {
            return context.BlindAction;
        }

        public override Task<PlayerAction> GetTurn(IGetTurnContext context)
        {
            return Task.FromResult(PlayerAction.Raise(context.MoneyLeft - context.MoneyToCall));
        }
    }
}
