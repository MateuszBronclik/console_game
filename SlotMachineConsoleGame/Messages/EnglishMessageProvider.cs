namespace SlotMachine.Messages
{
    public class EnglishMessageProvider : MessageProvider
    {
        public override string WelcomeMessage => "Welcome to the gates of Olympus Newcomer.";
        public override string SpinInstructions => "Press enter to spin the reels.";
        public override string GameOverMessage => "You have fallen into the depths of Hades. Game over!";
        public override string GameStartCredits => "Goddess Tyche known also as a Fortuna has awarded you with credits.";
    }
}
