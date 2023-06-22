using TradingSystem.Strategies.DayIn.AuctionStates;

namespace TradingSystem.Strategies.DayIn.OrderState;

public class ParentOrderCancelled : ITsOrderState
{
    private readonly IAuctionState _auctionState;

    public ParentOrderCancelled(IAuctionState auctionState) => _auctionState = auctionState;
    public IAuctionState HandleOrderChange() => _auctionState.OnParentCancellationRequested();
}