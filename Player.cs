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
        public string ChosenGesture;
       
      public List<string> RPSLS = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        
        public Player()
        {
         

        }
        public abstract void ChooseGesture();
       
    }

}
