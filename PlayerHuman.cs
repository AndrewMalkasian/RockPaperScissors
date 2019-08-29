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

            
           
        }

        public override void ChooseGesture()
        {
            Console.WriteLine("Manipulate your hand properly to defeat your opponent.");
            Console.WriteLine("Your Options: (1) Rock | (2) Paper (3) Scissors | (4) Lizard | (5) Spock");
            UserInput = Console.ReadLine();
            switch (UserInput)
            { 
                case "1":
                    UserInput = RPSLS[0];     
                    break;
                case "2":
                    UserInput = RPSLS[1];
                    break;
                case "3":
                    UserInput = RPSLS[2];
                    break;
                case "4":
                    UserInput = RPSLS[3];
                    break;
                case "5":
                    UserInput = RPSLS[4];
                    break;
                default:
                    break;
            }


        }
       

        

    }
       
}
