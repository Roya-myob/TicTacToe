using System;

namespace Tictactoe
{
    public class GameEngine
    {
        private Board _board;
        private Player _player1;
        private Player _player2;
        private GameRules _gameRules;
        private GameIO _gameIo;
        

        public GameEngine(Board board, Player player1, Player player2, GameRules gameRules, GameIO gameIo)
        {
            _board = board;
            _player1 = player1;
            _player2 = player2;
            _gameRules = gameRules;
            _gameIo = gameIo;
           
        }

        public void Start()
        {
            InitiateBoard();
            InitiatePlayer();
            Play();
            ShowResult();
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
            while (_gameRules.GetGameState(_board, _player1, _player2) == GameState.GAME_CONTINIUES)
            {
                _gameRules.Play(_player1, _board);

                if ((_gameRules.GetGameState(_board, _player1, _player2) == GameState.GAME_CONTINIUES))
                {
                    _gameRules.Play(_player2, _board);
                }
            }
        }

        public void ShowResult()
        {
            _gameIo.ShowResult(_gameRules.GetGameState(_board, _player1, _player2));
            
        }
    }
}