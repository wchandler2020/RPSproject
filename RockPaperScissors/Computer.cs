using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{

    class Computer : Player
    {
        public override void chooseGesture()
        {
            Random random = new Random();
            int choiceNumber = random.Next(5);
            gestureChoice = choiceNumber;
        }
    }
}
