using System.Collections.Generic;

namespace Tictactoe
{
    public class Player
    {
        private string _name;
        private List<Coord>  _coord;
        
        

        public Player(string name)
        {
            _name = name;
            Play();

        }

        public void Play()
        {
           _coord = new List<Coord>();
        }

        public string GetName()
        {
            return _name;
        }
        
        //query
        public Coord GetCoord()
        {
            return _coord;
        }
        
        //command
        public void AddCoord(Coord coord)
        {
            _coord = coord;
        }
      
    }
}