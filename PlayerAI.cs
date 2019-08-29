using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class PlayerAI : Player
    {
       
        public PlayerAI()
        {

            scoreCount = 0;

        }

        public override void ChooseGesture()
        {
            Random randomGesture = new Random();
           List<string> RPSLS = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };

            var list = randomGesture.Next(0, 5);
            Console.WriteLine("T3000 has randomly choosen " + RPSLS[list]);
            
        }
    }
}
