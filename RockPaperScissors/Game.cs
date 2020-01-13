using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {

        List<string> GameList = new List<string>();

        public void gameInit()
        {
            Console.WriteLine("Do you want to play Papper Rock Scissors? Please enter yes or no. ");
            string userInput = Console.ReadLine();

            if(userInput == "yes" || userInput == "y")
            {
                Console.WriteLine("What is your name? ");
                string username = Console.ReadLine().ToUpper();
                Console.WriteLine($"Hello {username}, let's get started. ");
                Console.ReadLine();
            }else if(userInput == "no" || userInput == "n")
            {
                Console.WriteLine("That's okay, maybe next time? ");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("that is not a valid choice");
                gameInit();            
            }
        }
        public void playGame()
        {
            GameList.Add("Rock");
            GameList.Add("Paper");
            GameList.Add("Scissors");

            foreach (string pieces in GameList)
            {
                Console.WriteLine($"game pieces: {pieces}");    
            }
            Console.ReadLine();
        }
    }
}
