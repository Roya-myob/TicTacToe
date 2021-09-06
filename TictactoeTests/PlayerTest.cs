using Tictactoe;
using Xunit;

    namespace TictactoeTests
    {
        public class PlayerTest
        {

            [Fact]
            public void Player_Has_A_Name_X()
            {
                Player player = new Player("x");

                var actual = player.CheckName();
                var expected = "X";
                
                Assert.Equal(expected, actual);
                
            }
            
            [Fact]
            public void Player_Provides_2_Numbers()
            {
                Player player = new Player("x");

                var actual = player.PlaceNumbers("1,1");
                var expected = "1,1";
                
                Assert.Equal(expected, actual);
            }
          

        }
    }
