using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {



        string option1 = Rock;
        string option2 = Roc


        public void Gestures()
        {
            List<string> gestures = new List<string>() {"Rock", "Paper", "Scissors", "Lizard", "Spock" };




            public void CallingRock()
            {
                if (Opponent.ChooseGesture() == gestures[2] || Opponent.ChooseGesture() == gestures[3]) // wins against Scissors and Lizard
                {
                  //ADD METHOD  PlayerWinTurn();
                }
                
                else if (Opponent.ChooseGesture() == gestures[1] || Opponent.ChooseGesture() == gestures[1]) // loses against Paper and Spock
                { 
                    //ADD METHOD PlayerLoseTurn();
                }
                else (Opponent.ChooseGesture() == gestures[0]) // ties itself
                {
                    //ADD METHOD TieAndRepeat();
                }

            }

            public void CallingPaper()
            {
                if (Opponent.ChooseGesture() == gestures[0] || Opponent.ChooseGesture() == gestures[5]) // wins against rock and Spock
                {
                   //ADD METHOD PlayerWinTurn();
                }

                else if (Opponent.ChooseGesture() == gestures[2] || Opponent.ChooseGesture() == gestures[3]) //loses against Scissors + Lizard
                {
                    //ADD METHOD PlayerLoseTurn
                }

                else (Opponent.ChooseGesture() == gestures[1]) // ties itself
                {
                    //ADD METHOD TieAndRepeat();
                }
            }

            public void CallingScissors()
            {
                if (Opponent.ChooseGesture() == gestures[1] || Opponent.ChooseGesture() == gestures[3]) // wins against Paper and Lizard
                {
                   //ADD METHOD PlayerWinTurn();
                }

                else if (Opponent.ChooseGesture() == gestures[0] || Opponent.ChooseGesture() == gestures[4]) // loses against Rock and Spock
                {
                // ADD METHOD PlayerLoseTurn();
                }
                else (Opponent.ChooseGesture() == gestures[2]) // ties itself 
                {
                //ADD FUNCTION TieAndRepeat();
                }


        }

        public void CallingLizard()
            {
                if (Opponent.ChooseGesture() == gestures[1] || Opponent.ChooseGesture() == gestures[4]) // wins against paper + Spock
                {
                  //ADD METHOD PlayerWinTurn();
                }

                else if (Opponent.ChooseGesture() == gestures[0] || Opponent.ChooseGesture() == gestures[2]) //loses against Rock + Scissors
                {
                // ADD METHOD PlayerLoseTurn()
                }
                else (Opponent.ChooseGesture() == gestures[3]) // ties itself 
                {
                //ADD METHOD TieAndRepeat();
            }
        }

            public void CallingSpock()
            {
                if (Opponent.ChooseGesture() == gestures[0] || Opponent.ChooseGesture() == gestures[2]) // wins against Rock and Scissors
                {
                  //ADD METHOD  PlayerWinTurn();
                }

                else if (Opponent.ChooseGesture() == gestures[1] || Opponent.ChooseGesture() == gestures[3]) // loses against Paper + Lizard
                {
                 //ADD METHOD PlayerWinTurn();
                }
                else (Opponent.ChooseGesture() == gestures[4]) // ties itself
                {
                //ADD METHOD TieAndRepeat();
            }
        }

        }
    }
}
