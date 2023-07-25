using System;
namespace RPSLS
{
	public class Human : Player
	{

        //HAS A
        
        //Constructor
        public Human(string name):base (name)
		{
            
            
		}

        //CAN DO
        public override void ChooseGesture()
        {            
            
            {
                Console.WriteLine($"Here are your options (Choose one):\n Rock\n Paper\n Scissors\n Lizard\n Spock\n");
                Console.WriteLine("Enter your choice: ");
                chosenGesture = Console.ReadLine();
                Console.WriteLine($"Player chooses {chosenGesture}");

            }
            
        }

    }
}

