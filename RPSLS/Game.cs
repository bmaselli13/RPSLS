﻿using System;
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
            this.playerOne = playerOne;

            //Player 2 name
            this.playerTwo = playerTwo;

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
            //Create a human player based on the users input
            //Create a Computer player if only one player entered
            if (numberOfHumanPlayers >= 1)
            {
                Human playerOne = new Human(this.playerOne.name);
                Human playerTwo = new Human(this.playerTwo.name);
            }
            else if(numberOfHumanPlayers == 1)
            {
                Human playerOne = new Human(this.playerOne.name);
                Computer playerTwo = new Computer(this.playerTwo.name);
            }
                
                

        }

        public void CompareGestures()
        {
            
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
            }
            else if(playerTwoScore > 1)
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
