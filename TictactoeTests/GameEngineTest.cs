using Tictactoe;
using Xunit;

namespace TictactoeTests
{
    public class GameEngine
    {
        [Fact]
        public void Show_Welcome_Message()
        {
            PrintIO printIo = new PrintIO();

            var actual = printIo.PrintWelcomeMessage();
            var expected = "Welcome to Tic Tac Toe!";
            
            Assert.Equal(expected, actual);

        }

    }
    
}