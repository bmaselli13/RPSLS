using System;
using System.Xml.Linq;

namespace RPSLS
{
    public class Computer : Player
    {

        //HAS A
        
        //Constructor
        public Computer(string name) : base(name)
        {
            
            
        }

            //CAN DO
            public override void ChooseGesture()
        {
            
            Random random = new Random();
            chosenGesture = new string[] { "Rock", "Paper", "Scissors", "Lizard", "Spock" }[random.Next(5)];

            Console.WriteLine("Computer chooses: " + chosenGesture);

        }
        
    }
}

