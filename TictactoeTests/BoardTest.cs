using System;
using Tictactoe;
using Xunit;

namespace TictactoeTests
{
    public class BoardTest
    {

        [Fact]
        public void Selected_Coordinate_Is_In_The_Range()
        {
            Board board = new Board();
            Coord coord = new (1,3);

            var actual = board.IsCoordinateAvailable(coord);
            var expected = true;

            Assert.Equal(expected, actual);
        }

        [Fact] //write text fixture 
        public void Selected_Coordinate_Is_Not_In_The_Range()
        {
            Board board = new Board();
            Coord coord = new (0,0);

            var actual = board.IsCoordinateAvailable(coord);
            var expected = false;

            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void Selected_Coordinate_Is_In_The_Range_But_Not_Available()
        {
            Board board = new Board();
            Coord coord = new (1,3);
            var value = "X";

            var actual = board.IsCoordinateAvailable(coord);
            board.UpdateNameOnBoard(coord, value);
            var expected = true;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Update_Board_Value()
        {
            Board board = new Board();
            Coord coord = new (1,3);
            var value = "X";
          

            board.UpdateNameOnBoard(coord, value);
            var expected = "X";

            var actual = board.GetValue(coord);
            
            Assert.Equal(expected, actual);
            
            

        }   
        
        /*
         * Additional tests to write:
         * GetValue -> Success case, failure case(s)
         *
         * Logic for adding loop so the it keeps asking for the coord and also
         * add logic for q 
         */
        




    }
}

