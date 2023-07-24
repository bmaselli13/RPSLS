using System;
namespace RPSLS
{
	public class Human : Player
	{

		//HAS A

		//Constructor
		public Human(string name):base (name)
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

