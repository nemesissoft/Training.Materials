using Common;
using DataProviderSystem;

namespace TradingSystem.Strategies.Sniper;

public abstract class FinalStateBase :ISniperState
{
    protected FinalStateBase(TsOrder parentOrder) => ParentOrder = parentOrder;

    public TsOrder ParentOrder { get; }

    public ISniperState Validate() => this;

    public ISniperState MarketDataReceived(MarketData marketData) => this;

    public ISniperState ChildOrderChanged(OrderChangeType changeType, TsOrder childOrder) => this;

    public ISniperState ParentOrderChanged(OrderChangeType changeType, TsOrder parentOrder) => this;
}