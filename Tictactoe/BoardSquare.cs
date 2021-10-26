using System.Net;

namespace Tictactoe
{
    public class BoardSquare
    {
        private Coord _coord;
        private string _value = ".";

        public BoardSquare(Coord coord)
        {
            _coord = coord;
            
        }

        public Coord GetCoord()
        {
            return _coord;
        }

        public string GetValue()
        {
            return _value;
        }

        public void UpdateValue(string name)
        {
            _value = name;
        }
    }
}