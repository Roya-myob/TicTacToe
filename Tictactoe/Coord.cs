using Tictactoe;

namespace Tictactoe
{
    public class Coord
    {
        private int _X;
        private int _Y;


        public Coord(int X, int Y)
        {
            _X = X;
            _Y = Y;
        }

        public int GetX()
        {
            return _X;
        }
        
        public int GetY()
        {
            return _Y;
        }

        public bool IsEqual(Coord coord)
        {
            if (coord.GetX() == _X && coord.GetY() == _Y) 
            {
                return true;
            }

            return false;
        }
    }
}
