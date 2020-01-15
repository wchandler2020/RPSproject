using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Player
    {
        public string name;
        public int score;
        public int gestureChoice;
        public List<string> GameList = new List<string>() { "Paper", "Rock", "Scissors", "Spock", "Lizard" };

        public Player(){}

        public virtual void chooseGesture(){}
    }
}
