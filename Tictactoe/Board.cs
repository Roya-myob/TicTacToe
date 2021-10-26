using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;

namespace Tictactoe
{
    public class Board
    {
        private List<BoardSquare> availableCoords = new List<BoardSquare>();

        public Board()
        {
          BuildBoard();

        }

        public void BuildBoard()
        {
            availableCoords = new List<BoardSquare>()
            {
               new BoardSquare(new Coord(1, 1)),
               new BoardSquare(new Coord(1, 2)),
               new BoardSquare(new Coord(1, 3)),
               new BoardSquare(new Coord(2, 1)),
               new BoardSquare(new Coord(2, 2)),
               new BoardSquare(new Coord(2, 3)),
               new BoardSquare(new Coord(3, 1)),
               new BoardSquare(new Coord(3, 2)),
               new BoardSquare(new Coord(3, 3)),
            };
        }

        public void UpdateNameOnBoard(Coord coord, string name)
        {
            
            for (int i = 0; i < availableCoords.Count; i++)
            {
               if (coord.IsEqual(availableCoords[i].GetCoord()))
                {
                    availableCoords[i].UpdateValue(name);
                }
            }
          
        }
        
        

        
        public string GetValue(Coord coord)
        {
            // string value = "";
            for (int i = 0; i < availableCoords.Count; i++)
            {
                if (coord.IsEqual(availableCoords[i].GetCoord()))
                {
                   return  availableCoords[i].GetValue();
                }
            }

            return "";

        }
       
        
        public bool IsCoordinateAvailable(Coord coord)
        {
            for (int i = 0; i < availableCoords.Count; i++)
           {
               if (coord.IsEqual(availableCoords[i].GetCoord()))
               {
                   if (availableCoords[i].GetValue() == ".")
                   {
                       return true;
                   }
                   
                   else return false;
                   
               }
           }

           return false;
        }

      }
}


