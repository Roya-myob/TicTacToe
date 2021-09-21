using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Tictactoe
{
    public class Board
    {
        private Coord [] BoardCoord = new Coord[]{};
        
        public Board()
        {
          InitiateBoard();

        }

        public void InitiateBoard()
        {
            BoardCoord = new[]
            {
                new Coord(1, 1),
                new Coord(1, 2),
                new Coord(1, 3),
                new Coord(2, 1),
                new Coord(2, 2),
                new Coord(2, 3),
                new Coord(3, 1),
                new Coord(3, 2),
                new Coord(3, 3),
                
            };
        }
        
        public bool IsCoordinateAvailable(Player player)
        {
          Coord playersCoord = player.GetCoord();

          // BoardCoord.Any(c => c.IsEqual(playersCoord));
          // LINQ
          
          for (int i = 0; i < BoardCoord.Length; i++)
           {
               if (playersCoord.IsEqual(BoardCoord[i]))
               {
                   return true;
               }
           }

           return false;
        }

        public void Play(Player player)
        {
            while (!IsCoordinateAvailable(player))
            {
                
                
            }
            if (IsCoordinateAvailable(player))
            {
                //get the coord and add it to a list 
                //list 
                List<Coord> TakenCoords = new List<Coord>();    
                TakenCoords.Add( player.GetCoord());   
               
            }
        }
        
        
    }
}

// Board: Collection of Coords
// Player1: Collection of Coords
// Player2: Collection of Coords

/*

step1
board: [1,1], [1,2], [2,1], [2,2]
p1: []
p2: []

step2: p1 takes 1,2
board: [1,1], [2,1], [2,2]
p1: [1,2]
p2: []


Play: PlayerObject
Coord coord
while coord == invalid
    newCoord = GetCoordFromInput
    if newCoord is Valid and Available
        coord = newCoord

PlayerObject -> GiveCoord(coord)
BoardObject -> RemoveCoord(coord)
*/


/*

Board
Player
Input

*/