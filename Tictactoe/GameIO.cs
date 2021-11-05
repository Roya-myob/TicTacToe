using System;
using System.Globalization;
using System.Linq;

namespace Tictactoe
{
    public class GameIO : IO
    {
        public void AskPlayerForCoordinates(Player player)
        {
            Console.Write(player.GetName() + "  enter coord x,y to place your or enter 'q' to give up!  ");
        }


        public string GetPlayerInput()
        {
            string playersInput = Console.ReadLine();
            return playersInput;
        }

        public void DrawGame(Board board)
        {
            var r1One = board.GetValue(new Coord(1, 1));
            var r1Two = board.GetValue(new Coord(1, 2));
            var r1Three = board.GetValue(new Coord(1, 3));
            var r2One = board.GetValue(new Coord(2, 1));
            var r2Two = board.GetValue(new Coord(2, 2));
            var r2Three = board.GetValue(new Coord(2, 3));
            var r3One = board.GetValue(new Coord(3, 1));
            var r3Two = board.GetValue(new Coord(3, 2));
            var r3Three = board.GetValue(new Coord(3, 3));

            Console.WriteLine($"{r1One} {r1Two}  {r1Three}");
            Console.WriteLine($"{r2One} {r2Two}  {r2Three}");
            Console.WriteLine($"{r3One} {r3Two}  {r3Three}");
        }


        public void LogCurrentState(Board board)
        {
            Console.WriteLine("Move accepted, here's the current board:");
        }

        public void ShowResult(GameState gameState)
        {
            if (gameState == GameState.PLAYER1_WINS)
            {
                Console.WriteLine("Player X won!");
            }

            if (gameState == GameState.PLAYER2_WINS)
            {
                Console.WriteLine("Player O won!");
            }
        }
    }
}