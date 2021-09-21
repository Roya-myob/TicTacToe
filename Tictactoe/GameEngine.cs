namespace Tictactoe
{
    public class GameEngine // run function ; entry point 
    {
        private Board _board;
        private Player _player;
        private GameRules _gameRules;

        public GameEngine(Board board, Player player, GameRules gameRules)
        {
            _board = board;
            _player = player;
            _gameRules = gameRules;

        }

        public void Run()
        {
            _gameRules.StartTheGame();
        }
        
        
        
    }
}