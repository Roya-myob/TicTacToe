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
            return  _UserInputForTest[_index++];
            
        }
    }
}

/*

var testIo = new TestIO('abc', '1,100', 'q');

... our GameRules will use our TestIO

_io.GetPlayerInput() => returns 'abc'
_io.GetPlayerInput() => returns '1,100'
_io.GetPlayerInput() => returns 'q'
_io.GetPlayerInput() => Throw exception

*/