using System.Collections.Generic;

namespace Tictactoe
{
    public class Player
    {
        private string _name;
        

        public Player(string name)
        {
            _name = name;
        }

        public string CheckName()
        {
            return _name;
        }

       
        
        public string PlaceNumbers(string numbers)
        {
            return numbers;
        }

      
    }
}