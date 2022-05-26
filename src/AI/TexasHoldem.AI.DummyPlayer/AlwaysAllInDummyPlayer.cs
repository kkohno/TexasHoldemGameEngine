using System.Threading.Tasks;

namespace TexasHoldem.AI.DummyPlayer
{
    using System;

    using TexasHoldem.Logic.Players;

    internal class AlwaysAllInDummyPlayer : BasePlayer
    {
        public override string Name { get; } = "AlwaysAllInDummyPlayer_" + Guid.NewGuid();

        public override int BuyIn { get; } = -1;

        public override PlayerAction PostingBlind(IPostingBlindContext context)
        {
            return context.BlindAction;
        }

        public override Task<PlayerAction> GetTurn(IGetTurnContext context)
        {
            if (context.MoneyLeft > 0)
            {
                return Task.FromResult(PlayerAction.Raise(context.MoneyLeft - context.MoneyToCall));
            }
            else
            {
                return Task.FromResult(PlayerAction.CheckOrCall());
            }
        }
    }
}
