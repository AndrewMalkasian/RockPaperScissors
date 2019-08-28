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
        public int turn;
        public int scoreCount;
        

        public Player()
        {

        }

        public virtual void Winner()
        {
            Console.WriteLine("You won! Would you like to play again?");
        }

        public virtual void Loser()
        {

        }

        public abstract void ChooseGesture();
 
    }
}
