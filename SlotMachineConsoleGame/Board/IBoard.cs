namespace SlotMachine.Board
{
    public interface IBoard
    {
        void Generate();
        void Display();
        string[,] GetBoardState();
    }

}
