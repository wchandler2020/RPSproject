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
        HumanPlayer human1 = new HumanPlayer();
        HumanPlayer human2;

        public void gameInit()
        {
            Console.WriteLine("Thank you for checking out Paper Rock Scissors Lizzards and Spock. ");
            Console.WriteLine("\n\nScissors cuts paper, paper covers rock, rock crushes lizard, lizard poisons\nSpock, Spock smashes scissors, scissors decapitates lizard, lizard eats paper,\npaper disproves Spock, Spock vaporizes rock, and as it always has, rock crushes \nscissors.\n\n");
            Console.WriteLine("Would you like to play? Please enter yes or no. ");
            string userInput = Console.ReadLine();
            
            if (userInput == "yes" || userInput == "y")
            {
                Console.WriteLine("What is Player ones name? ");
                human1.name = Console.ReadLine();
                Console.WriteLine($"Hello {human1.name}, let's get started. ");
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

        public void selectPlayers()
        {
            Console.WriteLine("How many players will there be. Please enter 1 or 2. ");
            int playerNumber = int.Parse(Console.ReadLine());

            if(playerNumber == 1)
            {
                Console.WriteLine("One Player game it is.");
                Console.ReadLine();
            }else if(playerNumber == 2)
            {
                Console.WriteLine("Two Player game it is.");
                Console.ReadLine();
            }
        }
        public void makeChoice()
        {
           
        }
        public void playGame()
        {
            Console.WriteLine("Please make a selection");
            Console.ReadLine();
            for (int i = 0; i < GameList.Count; i++)
            {
                Console.WriteLine($"{i +1}{'.'} {GameList[i]}");
            }
            Console.ReadLine();
        }
    }
}
