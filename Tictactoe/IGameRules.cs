namespace Tictactoe
{
    public interface IGameRules
    {
        public void StartGame(Board board, Player player1, Player player2);

        public void PlayersTurn(Player player);

        public void StateOfGame(Board board, Player player1, Player player2);

    }
}