using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {
        //1. Write the logic for comparing gestures inside a CompareGestures() method. if(player1.gestureChoice == "rock" && player2.gestureChoice)
        //2. Determine if there is a game winner
        List<string> GameList = new List<string>() { "Paper", "Rock", "Scissors", "Spock", "Lizard" };
        Player player1 = new HumanPlayer();
        Player player2;

        public void gameInit()
        {
            Console.WriteLine("Thank you for checking out Paper Rock Scissors Lizzards and Spock. ");
            Console.WriteLine("\n\nScissors cuts paper, paper covers rock, rock crushes lizard, lizard poisons\nSpock, Spock smashes scissors, scissors decapitates lizard, lizard eats paper,\npaper disproves Spock, Spock vaporizes rock, and as it always has, rock crushes \nscissors.\n\n");
            Console.WriteLine("Would you like to play? Please enter yes or no. ");
            string userInput = Console.ReadLine();
            
            if (userInput == "yes" || userInput == "y")
            {  
                selectPlayers();
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
                Console.WriteLine("One Player game it is. Press ENTER to continue");
                Console.WriteLine("Enter a name for player 1");
                player1.name = Console.ReadLine();
                player2 = new Computer();
                player2.name = "JOSHUA";
                Console.ReadLine();
                playGame();
                
            }
            else if(playerNumber == 2)
            {
                Console.WriteLine("Two Player game it is. Press ENTER to Continue.");
                player2 = new HumanPlayer();
                Console.WriteLine("Enter a name for player 1");
                player1.name = Console.ReadLine();
                Console.WriteLine("Enter a name for Player 2");
                player2.name = Console.ReadLine();
                playGame();
            }
            else
            {
                Console.WriteLine("Invalid selection, please enter 1 or 2");
                Console.ReadLine();
            }
        }
       

        public void compareGestures()
        {
            if (player1.gestureChoice == player2.gestureChoice)
            {
                Console.WriteLine("It is a tie.");
                Console.ReadLine();
            }
            else if (player1.gestureChoice == 1 && (player2.gestureChoice == 2 || player2.gestureChoice == 5))
            {
                player1.score++;
                Console.WriteLine($"{player1.name}: {player1.score}{"  "} {player2.name}: {player2.score}");
                Console.ReadLine();
            }
            else if (player1.gestureChoice == 2 && (player2.gestureChoice == 4 || player2.gestureChoice == 3))
            {
                player1.score++;
                Console.WriteLine($"{player1.name}: {player1.score}{"  "} {player2.name}: {player2.score}");
                Console.ReadLine();
            }
            else if (player1.gestureChoice == 3 && (player2.gestureChoice == 1 || player2.gestureChoice == 4))
            {
                player1.score++;
                Console.WriteLine($"{player1.name}: {player1.score}{"  "} {player2.name}: {player2.score}");
                Console.ReadLine();
            }
            else if (player1.gestureChoice == 4 && (player2.gestureChoice == 1 || player2.gestureChoice == 5))
            {
                player1.score++;
                Console.WriteLine($"{player1.name}: {player1.score}{"  "} {player2.name}: {player2.score}");
                Console.ReadLine();
            }
            else if (player1.gestureChoice == 5 && (player2.gestureChoice == 2 || player2.gestureChoice == 3))
            {
                player1.score++;
                Console.WriteLine($"{player1.name}: {player1.score}{"  "} {player2.name}: {player2.score}");
                Console.ReadLine();
            }
            else
            {
                player2.score++;
                Console.WriteLine($"{player1.name}:  {player1.score}{"  "} {player2.name}: {player2.score}");
                Console.ReadLine();
            }
        }

        public void playGame()
        {
            while (player1.score < 2 && player2.score < 2)
            {
                for (int i = 0; i < GameList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}{'.'} {GameList[i]}");
                }
                player1.chooseGesture();
                player2.chooseGesture();
                compareGestures();
            }
            determineWinner();
        }

        public void determineWinner()
        {
            if(player1.score == 2)
            {
                Console.WriteLine($"Great Job {player1.name}, you are the winner!!!");
                Console.ReadLine();
            }
            else{
                Console.WriteLine($"Great Job {player2.name}, you are the winner!!!");
                Console.ReadLine();
            }
        }
    }
}
