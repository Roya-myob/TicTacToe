using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Tictactoe
{
    public class GameRules : IGameRules
    {
        private IO _gameIO;

        public GameRules(IO gameIO)
        {
            _gameIO = gameIO;
        }


        public void StartGame(Board board, Player player1, Player player2)
        {
            throw new NotImplementedException();
        }


        public void Play(Player player, Board board)
        {
            Coord coord = new Coord(-1, -1);
            do
            {
                _gameIO.AskPlayerForCoordinates(player);
                var userInput = _gameIO.GetPlayerInput();
                if (userInput.Contains("q"))
                {
                    Console.WriteLine("you lost the game!");
                    GameState gameState = GameState.PLAYER2_WINS;
                }

                if (userInput.Contains(","))
                {
                    var splittedInput = userInput.Split(',');
                    coord = new Coord(int.Parse(splittedInput[0]), int.Parse(splittedInput[1]));
                }
            } while (!board.IsCoordinateAvailable(coord));

            board.UpdateNameOnBoard(coord, player.GetName());
            _gameIO.LogCurrentState(board);
            _gameIO.DrawGame(board);
        }

        public GameState GetGameState(Board board, Player player1, Player player2)
        {
            if (HasPlayerWon(player1, board))
            {
                return GameState.PLAYER1_WINS;
            }

            if (HasPlayerWon(player2, board))
            {
                return GameState.PLAYER2_WINS;
            }

            if (board.IsBoardFull())
            {
                return GameState.DRAW;
            }

            return GameState.GAME_CONTINIUES;
        }


        public bool HasPlayerWon(Player player, Board board)
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


            //horizontal
            if (r1One == r1Two && r1Two == r1Three && r1One.Contains(player.GetName()))
            {
                return true;
            }

            if (r2One == r2Two && r2Two == r2Three && r2One.Contains(player.GetName()))
            {
                return true;
            }

            if (r3One == r3Two && r3Two == r3Three && r3Two.Contains(player.GetName()))
            {
                return true;
            }

            //vertical
            if (r1One == r2One && r2One == r3One && r3One.Contains(player.GetName()))
            {
                return true;
            }

            if (r1Two == r2Two && r2Two == r3Two && r1Two.Contains(player.GetName()))
            {
                return true;
            }

            if (r1Three == r2Three && r2Three == r3Three && r1Three.Contains(player.GetName()))
            {
                return true;
            }

            //diagonal
            if (r1One == r2Two && r2Two == r3Three && r1One.Contains(player.GetName()))
            {
                return true;
            }

            if (r1Three == r2Two && r2Two == r3One && r1Three.Contains(player.GetName()))
            {
                return true;
            }


            return false;
        }


        public void StateOfGame(Board board, Player player1, Player player2)
        {
        }
    }
}