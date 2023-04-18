namespace SlotMachine.Symbols
{
    public abstract class Symbol : ISymbol
    {
        public abstract string EmojiRepresentation { get; }
        public abstract string Name { get; }
    }

}
