using System.Collections.Generic;

namespace Tictactoe
{
    public class Player
    {
        private string _name;
        private string _coord;
        

        public Player(string name, string coord)
        {
            _name = name;
            _coord = coord;
        }

        public string GetName()
        {
            return _name;
        }
        
        //query
        public string GetCoord()
        {
            return _coord;
        }
        
        //command
        public void AddCoord(string coord)
        {
            _coord = coord;
        }
      
    }
}