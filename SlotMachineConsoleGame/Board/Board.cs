using Spectre.Console;
using SlotMachine.Symbols;

namespace SlotMachine.Board;

public class Board : IBoard
{
    private readonly List<ISymbol> symbols;
    private string[,] boardState;
    private readonly Random random;

    public Board(List<ISymbol> symbols)
    {
        this.symbols = symbols;
        random = new Random();
        boardState = new string[3, 3];
    }

    public void Generate()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                boardState[i, j] = symbols[random.Next(0, symbols.Count)].EmojiRepresentation;
            }
        }
    }

    public void Display()
    {
        for (int i = 0; i < 3; i++)
        {
            string line = boardState[i, 0] + " " + boardState[i, 1] + " " + boardState[i, 2];
            AnsiConsole.MarkupLine(line);
        }
    }

    public string[,] GetBoardState()
    {
        return boardState;
    }
}
