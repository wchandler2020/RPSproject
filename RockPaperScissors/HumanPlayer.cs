using System;
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

            //switch case

            gestureChoice = int.Parse(Console.ReadLine());
            switch (gestureChoice)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Invalid selection, please enter 1 - 5");
                    Console.ReadLine();
                    chooseGesture();
                    break;

            }
        }
    }
}
