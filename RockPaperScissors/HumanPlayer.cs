﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class HumanPlayer : Player
    {
        public override void chooseGesture()
        {
            Console.WriteLine("Choose your gesture: ");
            int gestureChoice = int.Parse(Console.ReadLine());
        }
    }
}
