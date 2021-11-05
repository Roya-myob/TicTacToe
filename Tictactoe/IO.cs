namespace Tictactoe
{
    public interface IO
    {
        public void AskPlayerForCoordinates(Player player);

        public void LogCurrentState(Board board);

        public string GetPlayerInput();

        public void DrawGame(Board board);
    }
}