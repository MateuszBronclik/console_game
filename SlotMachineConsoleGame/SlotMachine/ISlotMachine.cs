namespace SlotMachine.SlotMachine
{
    public interface ISlotMachine
    {
        void Play(); // Metoda odpowiedzialna za rozpoczęcie gry
        int GetCredits(); // Metoda zwracająca ilość kredytów gracza
        int GetSpins(); // Metoda zwracająca ilość wykonanych spinów
        int GetHighestScore(); // Metoda zwracająca najwyższy wynik gracza
        // ... możesz dodać inne metody, które uważasz za stosowne
    }

}
