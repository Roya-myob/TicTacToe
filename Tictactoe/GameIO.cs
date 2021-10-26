using System;
using System.Globalization;
using System.Linq;

namespace Tictactoe
{
    public class GameIO : IO
    {
        public void AskPlayerForCoordinates(Player player)
        {
            Console.Write( player.GetName() + "  enter coord x,y to place your or enter 'q' to give up!  ");
        }

     

        public string GetPlayerInput()
        {
            string playersInput = Console.ReadLine();
            return playersInput;
        }
        
       
        
        public void LogCurrentState(Board board)
        {
            Console.WriteLine("Move accepted, here's the current board:" );
        }
    }
}