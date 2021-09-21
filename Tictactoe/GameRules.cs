namespace Tictactoe
{
    public class GameRules : IGameRules
    {
        private IO _gameIO;

        public GameRules(IO gameIO)
        {
            _gameIO = gameIO;
        }
        
        public void StartTheGame(Board board, Player player1, Player player2)
        {
           // Board board = new Board();
            board.InitiateBoard();// create a fresh board
            player1.Play(); // create a record for player []
            player2.Play();

        }

        public void PlayersTurn(Player player)
        {
            throw new System.NotImplementedException();
        }

        public void StateOfGame(Board board, Player player1, Player player2)
        {
            throw new System.NotImplementedException();
        }
    }

   
}

/*

current state:
board: -,-,o,x,x,o,-,-,-
player: [1,1]
player2: [2,3]

if you call gameRules.Start(board, player1, player2)
board: -,-,-,-,-,-,-
player1: []
player2: []

*/