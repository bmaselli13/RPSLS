using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player playerOne;
        public Player playerTwo;

        //Constructor
        public Game()
        {

        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS! Here are the rules:\n");
            Console.WriteLine("Rock crushes Scissors\nScissors cuts Paper \n" +
                "Paper covers Rock\nRock crushes Lizard\n" +
                "Lizard poisons Spock\n" + "Spock smashes Scissors\nScissors " +
                "decapitates Lizard\n" + "Lizard eats Paper\nPaper disproves " +
                "Spock\n" + "Spock vaporizes Rock\n");
            Console.WriteLine("The game will be best out of 3!\n");
        }

        public void ChooseNumberOfHumanPlayers()
        {
            Console.WriteLine("Choose the number of players:");
            int numberOfHumanPlayers = int.Parse(Console.ReadLine());

            if (numberOfHumanPlayers > 1)
            {
                CreatePlayerObjects(numberOfHumanPlayers);
            }
            else
            {
                CreatePlayerObjects(numberOfHumanPlayers);
            }

        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)

        {

            Console.WriteLine("Please 1 enter your name:");            
            string playerOneName = Console.ReadLine();            
                      

            if (numberOfHumanPlayers > 1)
            {
                Console.WriteLine("Please 2 enter your name:");                
                string playerTwoName = Console.ReadLine();

                playerOne = new Human(playerOneName);                               
                playerTwo = new Human(playerTwoName);
            }
            else if (numberOfHumanPlayers == 1)
            {
                
                playerOne = new Human(playerOneName);
                playerTwo = new Computer("Computer");
            }
            
            
        }

        public void CompareGestures()            

        {            

            while (playerOne.score < 2 && playerTwo.score < 2) // This loop allows the game to continue until there is a winner
            {
                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();
                
                if (playerOne.chosenGesture == "Rock" && playerTwo.chosenGesture == "Scissors")
                {
                    playerOne.score++;                              
                }
                else if ((playerOne.chosenGesture == "Scissors" && playerTwo.chosenGesture == "Rock"))
                {
                    playerOne.score++;
                }
                else if (playerOne.chosenGesture == "Paper" && playerTwo.chosenGesture == "Rock")
                {
                    playerOne.score++;
                }
                else if (playerOne.chosenGesture == "Paper" && playerTwo.chosenGesture == "Rock")
                {
                    playerTwo.score++;
                }
                else if (playerOne.chosenGesture == "Rock" && playerTwo.chosenGesture == "Lizard")
                {
                    playerOne.score++;
                }
                else if (playerOne.chosenGesture == "Lizard" && playerTwo.chosenGesture == "Rock")
                {
                    playerTwo.score++;
                }
                else if (playerOne.chosenGesture == "Lizard" && playerTwo.chosenGesture == "Spock")
                {
                    playerOne.score++;
                }
                else if (playerOne.chosenGesture == "Spock" && playerTwo.chosenGesture == "Lizard")
                {
                    playerTwo.score++;
                }
                else if (playerOne.chosenGesture == "Spock" && playerTwo.chosenGesture == "Scissors")
                {
                    playerOne.score++;
                }
                else if (playerOne.chosenGesture == "Scissors" && playerTwo.chosenGesture == "Spock")
                {
                    playerTwo.score++;
                }
                else if (playerOne.chosenGesture == "Scissors" && playerTwo.chosenGesture == "Lizard")
                {
                    playerOne.score++;
                }
                else if (playerOne.chosenGesture == "Lizard" && playerTwo.chosenGesture == "Scissors")
                {
                    playerTwo.score++;
                }
                else if (playerOne.chosenGesture == "Lizard" && playerTwo.chosenGesture == "Paper")
                {
                    playerOne.score++;
                }
                else if (playerOne.chosenGesture == "Paper" && playerTwo.chosenGesture == "Lizard")
                {
                    playerTwo.score++;
                }
                else if (playerOne.chosenGesture == "Paper" && playerTwo.chosenGesture == "Spock")
                {
                    playerOne.score++;
                }
                else if (playerOne.chosenGesture == "Spock" && playerTwo.chosenGesture == "Paper")
                {
                    playerTwo.score++;
                }
                else if (playerOne.chosenGesture == "Spock" && playerTwo.chosenGesture == "Rock")
                {
                    playerOne.score++;
                }
                else if (playerOne.chosenGesture == "Rock" && playerTwo.chosenGesture == "Spock")
                {
                    playerTwo.score++;
                }
                else if (playerOne.chosenGesture == playerTwo.chosenGesture)
                {
                    Console.WriteLine("It's a tie!");
                }
            }
            
        }

       public void DisplayGameWinner()
        {
            
            if(playerOne.score == 2)
            {
                Console.WriteLine("Player 1 wins the game!");               
            }
            else if(playerTwo.score == 2)
            {
                Console.WriteLine("Player 2 wins the game!");                
            }
        }

        public void RunGame()
        {
            //Step 1: Display the welcome message including rules of the game 
            WelcomeMessage();

            //Step 2: Ask how many human players will be playing
            //Logic: If only one player, create a human player and a computer
            //player.If 2 players, create 2 human players.
            ChooseNumberOfHumanPlayers();

            //Step 3: Ask each player which gesture they would like to pick
            //Logic: Compare those gestures to one another based on the rules of
            //the game to determine who wins. If one players wins, increment
            //their score by 1.
            playerOne.ChooseGesture();
            playerTwo.ChooseGesture();

            CompareGestures();

            //Step 4: Display the winner of round
            //Logic: depending on the outcome of the comparisons, display which
            //player one the round. 


            //Step 5: Repeat steps 3 and 4 until one of the players score
            //reaches 2
            //Logic: Use while loop to play multiple rounds


            //Step 6: Display winner of game
            //Logic: If a player reaches a score of 2, display the winner of the
            //round and on a new line the Game winner!
            DisplayGameWinner();

        }
    }
}
