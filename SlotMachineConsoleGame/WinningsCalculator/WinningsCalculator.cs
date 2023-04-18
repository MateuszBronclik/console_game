using SlotMachine.Symbols;

namespace SlotMachine.WinningsCalculator
{
    public class WinningsCalculator : IWinningsCalculator
    {
        public int CalculateWinnings(string[,] board, List<ISymbol> symbols)
        {
            int winnings = 0;

            // Check rows
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    winnings += 100;
                }
                else if (board[i, 0] == board[i, 1] || board[i, 1] == board[i, 2] || board[i, 0] == board[i, 2])
                {
                    winnings += 5;
                }
            }

            // Check columns
            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
                {
                    winnings += 100;
                }
                else if (board[0, i] == board[1, i] || board[1, i] == board[2, i] || board[0, i] == board[2, i])
                {
                    winnings += 5;
                }
            }

            // Check diagonals
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                winnings += 100;
            }
            else if (board[0, 0] == board[1, 1] || board[1, 1] == board[2, 2] || board[0, 0] == board[2, 2])
            {
                winnings += 5;
            }

            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                winnings += 100;
            }
            else if (board[0, 2] == board[1, 1] || board[1, 1] == board[2, 0] || board[0, 2] == board[2, 0])
            {
                winnings += 5;
            }
            return winnings;
        }
    }
}
