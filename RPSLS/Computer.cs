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
            this.chosenGesture = chosenGesture;
            this.score = score;
        }

            //CAN DO
            public override void ChooseGesture()
        {
            Console.WriteLine("Here are your options (Choose one): \"rock\", \"paper\", \"scissors\", \"lizard\", \"Spock\"");

        }
        
    }
}

