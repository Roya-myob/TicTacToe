using System.Collections.Generic;

namespace Tictactoe
{
    public class Board
    {
        
        public string DisplayPlayersInputOnTheBoard(Player player)
        {
            var coord = player.GetCoord();
            return coord;
        }
        

    }
}