using Tictactoe;
using Xunit;

    namespace TictactoeTests
    {
        public class PlayerTest
        {

            [Fact]
            public void Player_Has_A_Name_X()
            {
                Player player = new Player("x","1,1");

                var actual = player.GetName();
                var expected = "x";
                
                Assert.Equal(expected, actual);
                
            }
            
            [Fact]
            public void Get_Player_Coord_And_Store_it()
            {
                Player player = new Player("x", "1,1");
              

                var actual = player.GetCoord();
                var expected = "1,1";
                
                Assert.Equal(expected, actual);
            }
            
          

        }
    }
