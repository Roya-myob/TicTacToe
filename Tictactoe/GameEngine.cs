namespace Tictactoe
{
    public class GameEngine // run function ; entry point 
    {
        private Board _board;
        private Player _player1;
        private Player _player2;
        private GameRules _gameRules;

        public GameEngine(Board board, Player player1, Player player2, GameRules gameRules)
        {
            _board = board;
            _player1 = player1;
            _player2 = player2;
            _gameRules = gameRules;

        }

        public void Start()
        {
            InitiateBoard();
            InitiatePlayer();
            Play();

        }

        public void InitiateBoard()
        {
            _board.BuildBoard();
        }

        public void InitiatePlayer()
        {
            
        }

        public void Play()
        {
            while (!_gameRules.HasWon(_board,_player1, _player2))
            {
                _gameRules.Play(_player1, _board);
                _gameRules.Play(_player2, _board);
                
            }
           
        }
        
        
        
    }
}