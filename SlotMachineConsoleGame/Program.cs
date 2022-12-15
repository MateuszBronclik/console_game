using System.Text;

namespace SlotMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            SlotMachine game = new SlotMachine();
            game.Play();
        }
    }
    class SlotMachine
    {
        List<string> symbols = new List<string>()
        {
            "|Cherries \u03C6|","|Oranges \u03c3|","|Plums \u03d8|","|Bells \u03a8|","|Melons \u03f4|","|Bars \u03b8|"
        };
        private int credits;
        private int spins;
        private int highestScore;
        public void Play()
        {
            Random random = new Random();
            credits = random.Next(10, 101);

            Console.WriteLine($"Welcome to the gates of Olympus Newcomer. Goddess Tyche known also as a Fortuna has awarded you with {credits} credits. \nPress enter to spin the reels. " +
                $"\nEach spin costs you 10 credits.\nIf you match 3 symbols you will receive 100 credits.\nIf you match 2 symbols you will receive 5 credits." +
                $"\nTo finish the game and get to the pantheon of Gods you need to collect 500 points. Good luck!");

            while (true)
            {
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    string firstSymbol = symbols[random.Next(0, symbols.Count)];
                    string secondSymbol = symbols[random.Next(0, symbols.Count)];
                    string thirdSymbol = symbols[random.Next(0, symbols.Count)];
                    spins++;

                    Console.Clear();
                    Console.WriteLine($"{firstSymbol} {secondSymbol} {thirdSymbol}");

                    int winnings = CalculateWinnings(firstSymbol, secondSymbol, thirdSymbol);
                    Console.WriteLine($"You won: {winnings} credits!");

                    if (winnings == 0)
                    {
                        credits -= 10;
                    }
                    credits += winnings;

                    Console.WriteLine($"You have: {credits} credits.");
                    if (credits <= 0)
                    {
                        Console.WriteLine($"You have fallen into the depths of Hades. Game over! Number of spins {spins}");
                        Console.WriteLine($"Your highest score was {highestScore} credits");
                        Console.WriteLine($"Would you like to start again ? Y/N");
                        if (Console.ReadKey().Key == ConsoleKey.Y)
                        {
                            Console.Clear();
                            Play();
                        }

                        break;
                    }

                    if (credits >= 500)
                    {
                        Console.WriteLine("Fortune favours the brave!!! You can now sit on the throne next to other Gods! Congratulations!");
                        Console.WriteLine($"You earned {credits} credits and achieved this score in {spins} spins");
                        Console.WriteLine($"Would you like to start again ? Y/N");
                        if (Console.ReadKey().Key == ConsoleKey.Y)
                        {
                            Console.Clear();
                            Play();
                        }
                        break;
                    }
                    if (credits > highestScore)
                    {
                        highestScore = credits;
                    }
                }
            }
        }

        private int CalculateWinnings(string firstSymbol, string secondSymbol, string thirdSymbol)
        {
            int winnings = 0;

            if (firstSymbol == secondSymbol && secondSymbol == thirdSymbol)
            {
                winnings = 100;
            }
            else if (firstSymbol == secondSymbol || secondSymbol == thirdSymbol || firstSymbol == thirdSymbol)
            {
                winnings = 5;
            }
            return winnings;
        }
    }
}