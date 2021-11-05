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


            var actual = player.GetName();
            var expected = "x";

            Assert.Equal(expected, actual);
        }
    }
}