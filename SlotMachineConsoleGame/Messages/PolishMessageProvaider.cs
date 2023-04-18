namespace SlotMachine.Messages
{
    public class PolishMessageProvider : MessageProvider
    {
        public override string WelcomeMessage => "Witaj na bramach Olimpu!";
        public override string SpinInstructions => "Naciśnij Enter, aby zakręcić bębnami.";
        public override string GameOverMessage => "Zstąpiłeś w otchłań Hadesu. Koniec gry!";
        public override string GameStartCredits => "Bogini Tyche znana jako Fortuna wynagrodziła cię kredytami.";

    }
}
