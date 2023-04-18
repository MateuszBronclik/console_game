using System;
using System.Text;
using Spectre.Console;
using SlotMachine.SlotMachine;
using SlotMachine.Messages;
using SlotMachine.Symbols;
using SlotMachine.Board;
using SlotMachine.WinningsCalculator;


namespace SlotMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize game components
            var messageProvider = new EnglishMessageProvider();
            var symbols = InitializeSymbols();
            var board = new Board.Board(symbols);
            var winningsCalculator = new WinningsCalculator.WinningsCalculator();
            var slotMachineGame = new SlotMachineGame(board, messageProvider, winningsCalculator);

            // Display welcome message
            AnsiConsole.MarkupLine(messageProvider.WelcomeMessage);

            // Main game loop
            while (true)
            {
                // Display spin instructions
                AnsiConsole.MarkupLine(messageProvider.SpinInstructions);

                // Wait for user input to spin the reels
                Console.ReadLine();

                // Spin the reels
                slotMachineGame.Play();

                // Check if the game is over
                if (slotMachineGame.IsGameOver())
                {
                    AnsiConsole.MarkupLine(messageProvider.GameOverMessage);
                    break;
                }
            }
        }

        private static List<ISymbol> InitializeSymbols()
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
}
