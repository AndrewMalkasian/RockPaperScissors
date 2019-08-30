using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class PlayerHuman : Player
    {
        
        public PlayerHuman()
        {

            scoreCount = 0;
            
           
        }

        public override void ChooseGesture()
        {
            Console.WriteLine("Manipulate your hand properly to defeat your opponent.");
            Console.WriteLine("Your Options: (1) Rock | (2) Paper (3) Scissors | (4) Lizard | (5) Spock");
            UserInput = Console.ReadLine();
            switch (UserInput)
            { 
                case "1":
                    ChosenGesture = "Rock";
                    break;
                case "2":
                    ChosenGesture = "Paper";                   
                    break;
                case "3":
                    ChosenGesture = "Scissors";
                    break;
                case "4":
                    ChosenGesture = "Lizard";
                    break;
                case "5":
                    ChosenGesture = "Spock";
                    break;
                default:
                    break;
            }


        }
       

        

    }
       
}
