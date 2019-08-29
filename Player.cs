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
        public string UserInput;
       
      List<string> RPSLS = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        
        public Player()
        {
            scoreCount = 0;
     

        }
        public abstract void ChooseGesture();
        //public virtual void PlayerWinTurn()
        //{
            //ADD MORE WITH SCORE++     //add both chooseGestures();
            //Console.WriteLine(//Player.ChooseGesture() + "beats " + PlayerTwo.ChooseGesture());
            //Console.WriteLine(//"You won this turn!");
            //Console.WriteLine(//playerScore + PlayerTwoScore)

       // }

        //public virtual void PlayerLoseTurn()
       // {
            //ADD MORE WITH SCORE ++
            //Console.WriteLine(//"It's okay. PlayerTwo.ChooseGesture beat Player.ChooseGesture");
            //Console.WriteLine(//"You lost this turn. Keep trying!");
            //Console.WriteLine(//playerScore + PlayerTwoScore);
       // }
        //FIND A WAY TO MAKE AN OPPONENT VARIABLE WHERE THEY MATCH EACH OTHER UP.
        
      

        

    }

}
