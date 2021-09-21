using System;
using Tictactoe;
using Xunit;

namespace TictactoeTests
{
    public class BoardTest
    {

        [Fact]
        public void Each_Coordinates_Can_Be_Used_Once_In_Each_Game()
        {
            Board board = new Board();
            Player player = new Player("x", new Coord(1,1));   
            //player = new Player("x", new Coord(1,1));
            
            var actual = board.IsCoordinateAvailable(player);
            var expected = false;

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Selected_Coordinate_Is_In_The_Range()
        {
            Board board = new Board();
            Player player = new Player("x",new Coord(1,1));

            var actual = board.IsCoordinateAvailable(player);
            var expected = true;

            Assert.Equal(expected, actual);

        }
        
       
        
        
        
        /*[Theory]
        [InlineData("x",new Coord(1,1))]
        public void Selected_Coordinate_Is_In_The_Range(string value1, Coord value2, bool expected)
        {
            Board board = new Board();
            //Player player = new Player("x",new Coord(1,1));
            Player player = new Player(value1, value2);


            var actual = board.IsCoordinateAvailable(player);
            var result = true;

            Assert.Equal(expected, result);

        }*/
        



    }
}

