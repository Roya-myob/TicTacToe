﻿using Tictactoe;
using Xunit;

namespace TictactoeTests
{
    public class BoardSquareTest
    {
        [Fact] 
        public void Board_Has_A_Predefined_Value()
        {
            var boardsquare = new BoardSquare(new Coord(1,3));
            var value = ".";

            var actual = boardsquare.GetValue();
            var expected = value;

            Assert.Equal(expected, actual);
        }
        
        [Fact] 
        public void Board_Has_Updated_Value()
        {
            var boardsquare = new BoardSquare(new Coord(1,3));
            var value = "X";

            boardsquare.UpdateValue(value);
            var actual = boardsquare.GetValue();
            var expected = "X";

            Assert.Equal(expected, actual);
        }
    }
}

/*
    step1. Create instance of object
    step2. Perform mutations / actions
    step3. Get actual result from object
    step4. Assert against expected value
*/