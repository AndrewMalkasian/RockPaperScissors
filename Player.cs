using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public abstract class Player
    {
        public string name;
        public int scoreCount;
        public string gesture;
        List<string> gestures = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };

        public Player()
        {

        }

        public virtual void PlayerWinTurn()
        {
            //ADD MORE WITH SCORE++     //add both chooseGestures();
            //Console.WriteLine(//Player.ChooseGesture() + "beats " + UserTwo.ChooseGesture());
            //Console.WriteLine(//"You won this turn!");
            //Console.WriteLine(//playerScore + UserTwoScore)

        }

        public virtual void PlayerLoseTurn()
        {
            //ADD MORE WITH SCORE ++
            //Console.WriteLine(//"It's okay. UserTwo.ChooseGesture beat Player.ChooseGesture");
            //Console.WriteLine(//"You lost this turn. Keep trying!");
            //Console.WriteLine(//playerScore + UserTwoScore);
        }
        //FIND A WAY TO MAKE AN OPPONENT VARIABLE WHERE THEY MATCH EACH OTHER UP.
        public abstract void ChooseGesture();
        public void CallingRock()
        {
            if (UserTwo.gesture() == gestures[2] || UserTwo.ChooseGesture() == gestures[3]) // wins against Scissors and Lizard
            {
                //ADD METHOD  PlayerWinTurn();
            }

            else if (UserTwo.ChooseGesture() == gestures[1] || UserTwo.ChooseGesture() == gestures[1]) // loses against Paper and Spock
            {
                //ADD METHOD PlayerLoseTurn();
            }
            else if (UserTwo.ChooseGesture() == gestures[0]) // ties itself
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
            if (UserTwo.ChooseGesture() == gestures[0] || UserTwo.ChooseGesture() == gestures[5]) // wins against rock and Spock
            {
                //ADD METHOD PlayerWinTurn();
            }

            else if (UserTwo.ChooseGesture() == gestures[2] || UserTwo.ChooseGesture() == gestures[3]) //loses against Scissors + Lizard
            {
                //ADD METHOD PlayerLoseTurn
            }

            else if (UserTwo.ChooseGesture() == gestures[1]) // ties itself
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
            if (UserTwo.gesture == gestures[1] || UserTwo.ChooseGesture() == gestures[3]) // wins against Paper and Lizard
            {
                //ADD METHOD PlayerWinTurn();
            }

            else if (UserTwo.ChooseGesture() == gestures[0] || UserTwo.ChooseGesture() == gestures[4]) // loses against Rock and Spock
            {
                // ADD METHOD PlayerLoseTurn();
            }
            else if (UserTwo.ChooseGesture() == gestures[2]) // ties itself 
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
            if (UserTwo.ChooseGesture() == gestures[1] || UserTwo.ChooseGesture() == gestures[4]) // wins against paper + Spock
            {
                //ADD METHOD PlayerWinTurn();
            }

            else if (UserTwo.ChooseGesture() == gestures[0] || UserTwo.ChooseGesture() == gestures[2]) //loses against Rock + Scissors
            {
                // ADD METHOD PlayerLoseTurn()
            }
            else if (UserTwo.ChooseGesture() == gestures[3]) // ties itself 
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
            if (Player.gesture == gestures[0] || UserTwo.ChooseGesture() == gestures[2]) // wins against Rock and Scissors
            {
                //ADD METHOD  PlayerWinTurn();
            }

            else if (UserTwo.ChooseGesture() == gestures[1] || UserTwo.ChooseGesture() == gestures[3]) // loses against Paper + Lizard
            {
                //ADD METHOD PlayerWinTurn();
            }
            else if (UserTwo.ChooseGesture() == gestures[4]) // ties itself
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
