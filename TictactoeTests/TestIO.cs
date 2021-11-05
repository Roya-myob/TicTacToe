using System.Collections.Generic;
using Tictactoe;

namespace TictactoeTests
{
    public class TestIO : IO
    {
        private List<string> _UserInputForTest;
        private int _index = 0;

        public TestIO(List<string> UserInputForTest)
        {
            _UserInputForTest = UserInputForTest;
        }

        public void AskPlayerForCoordinates(Player player)
        {
        }

        public void LogCurrentState(Board board)
        {
        }

        public string GetPlayerInput()
        {
            return _UserInputForTest[_index++];
        }

        public void DrawGame(Board board)
        {
            
        }
    }
}