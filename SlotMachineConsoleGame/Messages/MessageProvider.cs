namespace SlotMachine.Messages
{
    public abstract class MessageProvider
    {
        public abstract string WelcomeMessage { get; }
        public abstract string SpinInstructions { get; }
        public abstract string GameOverMessage { get; }
        public abstract string GameStartCredits { get; }
        

    }
}
