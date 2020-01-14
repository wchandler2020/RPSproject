using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {

        List<string> GameList = new List<string>() { "Paper", "Rock", "Scissors", "Spock", "Lizard" };

        public void gameInit()
        {
            Console.WriteLine("Do you want to play Papper Rock Scissors? Please enter yes or no. ");
            string userInput = Console.ReadLine();


            if (userInput == "yes" || userInput == "y")
            {
                Console.WriteLine("What is your name? ");
                string username = Console.ReadLine();
                Console.WriteLine($"Hello {username}, let's get started. ");
                Console.ReadLine();
                Console.WriteLine();
                playGame();
            }
            else if (userInput == "no" || userInput == "n")
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
            for (int i = 0; i < GameList.Count; i++)
            {
                Console.WriteLine($"{i +1}{'.'} {GameList[i]}");
            }
            Console.ReadLine();
        }
    }
}
