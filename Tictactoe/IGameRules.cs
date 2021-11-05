namespace Tictactoe
{
    public interface IGameRules
    {
        public void StartGame(Board board, Player player1, Player player2);

        public void Play(Player player, Board board);

        public void StateOfGame(Board board, Player player1, Player player2);


        public bool HasPlayerWon(Player player, Board board);
    }
}