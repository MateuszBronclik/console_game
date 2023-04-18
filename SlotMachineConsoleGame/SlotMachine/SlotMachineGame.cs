using SlotMachine.Board;
using SlotMachine.Messages;
using SlotMachine.Symbols;
using SlotMachine.WinningsCalculator;


namespace SlotMachine.SlotMachine;

public class SlotMachineGame : ISlotMachine
{
    private List<ISymbol> symbols;
    private int credits;
    private int spins;
    private int highestScore;
    private IBoard board;
    private MessageProvider messageProvider;
    private IWinningsCalculator winningsCalculator;

    public SlotMachineGame(IBoard board, MessageProvider messageProvider, IWinningsCalculator winningsCalculator)
    {
        symbols = InitializeSymbols();
        this.board = board;
        this.messageProvider = messageProvider;
        this.winningsCalculator = winningsCalculator;
        // ... rest of initialization logic
    }

    public void Play()
    {
        
        board.Generate();
        board.Display();

        // ... reszta logiki gry
    }

    public int GetCredits()
    {
        Random random = new Random();
        credits = random.Next(10, 101);
        return credits;
    }

    public int GetSpins()
    {
        return spins;
    }

    public int GetHighestScore()
    {
        return highestScore;
    }

    public bool IsGameOver()
    {
        return credits <= 0;
    }

    private List<ISymbol> InitializeSymbols()
    {
        return new List<ISymbol>
        {
            new CherrySymbol(),
            new BellSymbol(),
            new OrangeSymbol(),
            new BlueberrySymbol(),
            new MelonSymbol(),
            new ChocolateBarSymbol(),
        };
    }
}
