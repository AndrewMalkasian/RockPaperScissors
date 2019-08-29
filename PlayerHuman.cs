using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class PlayerHuman : Player
    {
        List<string> gestures = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        public PlayerHuman()
        {
            this.name = name;
            this.gesture = gesture;

        }

        public override void ChooseGesture()
        {
            Console.WriteLine("Manipulate your hand properly to defeat your opponent.");
            Console.WriteLine("Your Options: (1) Rock | (2) Paper (3) Scissors | (4) Lizard | (5) Spock");
            UserOneInput = Console.ReadLine();
            switch(UserOneInput):

                case "1": CallingRock();
                case "2": CallingPaper();
                case "3": CallingScissors();
                case "4": CallingLizard();
                case "5": CallingSpock();
         
        }

        public void CallingRock()
        {
            if (UserOneInput == gestures[2] || UserOneInput == gestures[3]) // wins against Scissors and Lizard
            {
                //ADD METHOD  PlayerWinTurn();
            }

            else if (UserOneInput == gestures[1] || UserOneInput == gestures[1]) // loses against Paper and Spock
            {
                //ADD METHOD PlayerLoseTurn();
            }
            else if (UserOneInput == gestures[0]) // ties itself
            {
                //ADD METHOD TieAndRepeat();
            }
            else
            {
                //ADD METHOD ChooseGesture()
            }

        }

        public void CallingPaper()
        {
            if (UserOneInput == gestures[0] || UserOneInput == gestures[5]) // wins against rock and Spock
            {
                //ADD METHOD PlayerWinTurn();
            }

            else if (UserOneInput == gestures[2] || UserOneInput == gestures[3]) //loses against Scissors + Lizard
            {
                //ADD METHOD PlayerLoseTurn
            }

            else if (UserOneInput == gestures[1]) // ties itself
            {
                //ADD METHOD TieAndRepeat();

            }
            else
            {
                //ADD METHOD ChooseGesture()
            }

        }
        public void CallingScissors()
        {
            // UserTwo.ChooseGesture()
            if (UserOneInput == gestures[1] || UserOneInput == gestures[3]) // wins against Paper and Lizard
            {
                //ADD METHOD PlayerWinTurn();
            }

            else if (UserOneInput == gestures[0] || UserOneInput == gestures[4]) // loses against Rock and Spock
            {
                // ADD METHOD PlayerLoseTurn();
            }
            else if (UserOneInput == gestures[2]) // ties itself 
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
            if (UserOneInput == gestures[1] || UserOneInput == gestures[4]) // wins against paper + Spock
            {
                //ADD METHOD PlayerWinTurn();
            }

            else if (UserOneInput == gestures[0] || UserOneInput == gestures[2]) //loses against Rock + Scissors
            {
                // ADD METHOD PlayerLoseTurn()
            }
            else if (UserOneInput == gestures[3]) // ties itself 
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
            if (UserOneInput == gestures[0] || UserOneInput == gestures[2]) // wins against Rock and Scissors
            {
                //ADD METHOD  PlayerWinTurn();
            }

            else if (UserOneInput == gestures[1] || UserOneInput == gestures[3]) // loses against Paper + Lizard
            {
                //ADD METHOD PlayerWinTurn();
            }
            else if (UserOneInput == gestures[4]) // ties itself
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
