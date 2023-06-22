namespace TradingSystemConsole;

public static class ParamConverter
{
    public static decimal ToDecimal(string param) => decimal.TryParse(param, out var result) ? result : 0.0M;
}