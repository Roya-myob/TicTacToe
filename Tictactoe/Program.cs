using System;

namespace Tictactoe
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            Player player1 = new Player("X");
            Player player2 = new Player("Y");
            GameRules gameRules = new GameRules(new GameIO());
            
            GameEngine gameEngine = new GameEngine(board, player1, player2, gameRules);
            
            gameEngine.Start();
        }
    }
}