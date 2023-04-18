using SlotMachine.Symbols;

namespace SlotMachine.WinningsCalculator
{
    public interface IWinningsCalculator
    {
        int CalculateWinnings(string[,] board, List<ISymbol> symbols);
    }
}
