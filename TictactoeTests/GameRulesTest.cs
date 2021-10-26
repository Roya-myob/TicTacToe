using System.Collections.Generic;
using Tictactoe;
using Xunit;
using Assert = NUnit.Framework.Assert;

namespace TictactoeTests
{
    public class GameRulesTest
    {
        [Fact]
        public void New_Value_On_Board_Is_Updated_For_Given_Coord()
        {
            Player player = new Player("x");
            GameRules gameRules =
                new GameRules(new TestIO(new List<string>() { "5,6","1,3", "a,b", "0,0", "1,a", "_,." }));
            Board board = new Board();

            gameRules.Play(player, board);

           var result =  board.GetValue(new Coord(1,3));

           Assert.AreEqual(result, player.GetName());

        }
        [Fact]
        public void List_Of__Input()
        {
            Player player = new Player("x");
            GameRules gameRules =
                new GameRules(new TestIO(new List<string>() { "3,3","5,6","2,2","1,3", "a,b", "0,0" , "1,a", "_,." }));
            Board board = new Board();

            gameRules.Play(player, board);

            var result =  board.GetValue(new Coord(3,3));
            Assert.AreEqual(result, player.GetName());


        }
        
        [Fact]
        public void Player_Wins_When_All_The_First_Horizontal_Row_Is_Selected()
        {  
            Player player1 = new Player("X");
            Player player2 = new Player("Y");
            GameRules gameRules =
                new GameRules(new TestIO(new List<string>() { "1,1", "1,2", "1,3" }));
            Board board = new Board();
            
            gameRules.Play(player1, board);
            gameRules.Play(player1, board);
            gameRules.Play(player1, board);

            var result = gameRules.HasWon(board, player1, player2);
            Assert.AreEqual(result, true);


        }

        [Fact]
        public void NoMovesMade()
        {
            
            Player player1 = new Player("X");
            Player player2 = new Player("Y");
            GameRules gameRules =
                new GameRules(new TestIO(new List<string>() { }));
            Board board = new Board();
            
            var result = gameRules.HasWon(board, player1, player2);
            Assert.AreEqual(false, result);
        }
        [Fact]
        public void Player_Wins_When_All_The_First_Vertical_Columns_Is_Selected()
        {  
            Player player1 = new Player("X");
            Player player2 = new Player("Y");
            GameRules gameRules =
                new GameRules(new TestIO(new List<string>() { "1,1", "2,1", "3,1" }));
            Board board = new Board();
            
            gameRules.Play(player1, board);
            gameRules.Play(player1, board);
            gameRules.Play(player1, board);

            var result = gameRules.HasWon(board, player1, player2);
            Assert.AreEqual(result, true);
            
        }
        [Fact]
        public void Player_Wins_When_Diagonal_Is_Selected()
        {  
            Player player1 = new Player("X");
            Player player2 = new Player("Y");
            GameRules gameRules =
                new GameRules(new TestIO(new List<string>() { "1,1", "2,2", "3,3" }));
            Board board = new Board();
            
            gameRules.Play(player1, board);
            gameRules.Play(player1, board);
            gameRules.Play(player1, board);

            var result = gameRules.HasWon(board, player1, player2);
            Assert.AreEqual(result, true);
            
        }
        
        [Fact]
        public void Player_Loses_When_Selected_Positions_Are_Not_Next_To_Each_other()
        {  
            Player player1 = new Player("X");
            Player player2 = new Player("Y");
            GameRules gameRules =
                new GameRules(new TestIO(new List<string>() { "2,2", "3,1", "3,3" }));
            Board board = new Board();
            
            gameRules.Play(player1, board);
            gameRules.Play(player1, board);
            gameRules.Play(player1, board);

            var result = gameRules.HasWon(board, player1, player2);
            Assert.AreEqual(result, false);
            
        }
        [Fact]
        public void Player_Loses_When_Selected_Positions_Are_Not_Next_To_Each_other_2()
        {  
            Player player1 = new Player("X");
            Player player2 = new Player("Y");
            GameRules gameRules =
                new GameRules(new TestIO(new List<string>() { "1,3", "2,3", "3,2" }));
            Board board = new Board();
            
            gameRules.Play(player1, board);
            gameRules.Play(player1, board);
            gameRules.Play(player1, board);

            var result = gameRules.HasWon(board, player1, player2);
            Assert.AreEqual(result, false);
            
        }
       
    }
}