using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class PlayerHuman : Player
    {
        List<string> RPSLS = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };

        public PlayerHuman()
        {

            
           
        }
        
        public override void ChooseGesture()
        {
            Console.WriteLine("Manipulate your hand properly to defeat your opponent.");
            Console.WriteLine("Your Options: (1) Rock | (2) Paper (3) Scissors | (4) Lizard | (5) Spock");
            UserInput = Console.ReadLine();
            switch(UserInput) {

                case "1":
                    RPSLS[0] = "Rock";
                break;
                case "2":
                    RPSLS[1] = "Paper";
                break;
                case "3":
                    RPSLS[2] = "Scissors";
                break;
                case "4":
                    RPSLS[3] = "Lizard";
                break;
                case "5":
                    RPSLS[4] = "Spock";
                break;
            }
         
        }
        public void ComparingGestures()
        {
            
 
        }
        public void CallingRock()
        {
            if (UserInput == RPSLS[2] || UserInput == RPSLS[3]) // wins against Scissors and Lizard
            {
                //ADD METHOD  PlayerWinTurn();
            }

            else if (UserInput == RPSLS[1] || UserInput == RPSLS[1]) // loses against Paper and Spock
            {
                //ADD METHOD PlayerLoseTurn();
            }
            else if (UserInput == RPSLS[0]) // ties itself
            {
                
            }
            else
            {
                
            }

        }

        public void CallingPaper()
        {
            if (UserInput == RPSLS[0] || UserInput == RPSLS[5]) // wins against rock and Spock
            {
                //ADD METHOD PlayerWinTurn();
            }

            else if (UserInput == RPSLS[2] || UserInput == RPSLS[3]) //loses against Scissors + Lizard
            {
                //ADD METHOD PlayerLoseTurn
            }

            else if (UserInput == RPSLS[1]) // ties itself
            {
                //ADD METHOD TieAndRepeat();

            }
            else
            {
                CallingScissors();
      
            }

        }
        public void CallingScissors()
        {
            // PlayerTwo.ChooseGesture()
            if (UserInput == RPSLS[1] || UserInput == RPSLS[3]) // wins against Paper and Lizard
            {
                //ADD METHOD PlayerWinTurn();
            }

            else if (UserInput == RPSLS[0] || UserInput == RPSLS[4]) // loses against Rock and Spock
            {
                // ADD METHOD PlayerLoseTurn();
            }
            else if (UserInput == RPSLS[2]) // ties itself 
            {
                //ADD FUNCTION TieAndRepeat();
            }
            else
            {
                //ADD METHOD ChooseGesture();
            }

        }

        public void CallingLizard()
        {
            if (UserInput == RPSLS[1] || UserInput == RPSLS[4]) // wins against paper + Spock
            {
                //ADD METHOD PlayerWinTurn();
            }

            else if (UserInput == RPSLS[0] || UserInput == RPSLS[2]) //loses against Rock + Scissors
            {
                // ADD METHOD PlayerLoseTurn()
            }
            else if (UserInput == RPSLS[3]) // ties itself 
            {
                //ADD METHOD TieAndRepeat();
            }
            else
            {
                //ADD METHOD ChooseGesture();
            }
        }


        public void CallingSpock()
        {
            if (UserInput == RPSLS[0] || UserInput == RPSLS[2]) // wins against Rock and Scissors
            {
                //ADD METHOD  PlayerWinTurn();
            }

            else if (UserInput == RPSLS[1] || UserInput == RPSLS[3]) // loses against Paper + Lizard
            {
                //ADD METHOD PlayerWinTurn();
            }
            else if (UserInput == RPSLS[4]) // ties itself
            {
                //ADD METHOD TieAndRepeat();
            }
            else
            {
                //ADD METHOD ChooseGesture();
            }
        }
        

    }
}
