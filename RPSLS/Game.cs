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
        //public Player playerComp;

        //Constructor
        public Game()
        {
            //Player One Name
            //Player playerOne = new Player(name);

            //Player 2 name
            //this.playerTwo = playerTwo;

            //Computer Player
            //this.playerComp = playerComp;
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

            //string player1Choice = ;
            //string player2Choice = ;

            //Players choose their gestures


            //if (player1Choice == player2Choice)
            //{
            //    // It's a tie
            //    Console.WriteLine("It's a tie! Both players chose " + player1Choice);
            //}
            //else if (
            //    (player1Choice == "Rock" && (player2Choice == "Scissors" || player2Choice == "Lizard")) ||
            //    (player1Choice == "Paper" && (player2Choice == "Rock" || player2Choice == "Spock")) ||
            //    (player1Choice == "Scissors" && (player2Choice == "Paper" || player2Choice == "Lizard")) ||
            //    (player1Choice == "Lizard" && (player2Choice == "Paper" || player2Choice == "Spock")) ||
            //    (player1Choice == "Spock" && (player2Choice == "Rock" || player2Choice == "Scissors"))) ;
            
        }

        public void DisplayRoundWinner()
        {
      
        }

        public void DisplayGameWinner()
        {
            int playerOneScore = 0;
            int playerTwoScore = 0;

            if(playerOneScore > 1)
            {
                Console.WriteLine("Player 1 wins the game!");
                playerOneScore++;
            }
            else if(playerTwoScore > 1)
            {
                Console.WriteLine("Player 2 wins the game!");
                playerTwoScore++;
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
