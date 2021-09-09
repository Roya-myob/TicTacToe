using System;
using Tictactoe;
using Xunit;

namespace TictactoeTests
{
    public class BoardTest
    {
        [Fact]
        public void Display_Element_On_The_Board()
        {
            Board board = new Board();
            Player player = new Player("x", "."); 

           var actual = board.DisplayPlayersInputOnTheBoard(player);
            var expected = ".";
            
            Assert.Equal(expected ,actual);
        }
        [Fact]
        public void Display_Players_Coord_On_The_Board()
        {
            Board board = new Board();
            Player player = new Player("x", "1,1");            

            var actual = board.DisplayPlayersInputOnTheBoard(player);
            var expected = "1,1";
            
            Assert.Equal(expected ,actual);
        }
        
       
        
    }
}

