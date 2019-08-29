using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {
        Player UserOne;
        Player UserTwo;
        

        

        
        // member methods
        //RunGame (MASTER PROGRAM TO RULE THEM ALL)
        //MainMenu
        //Rules
        //number of Players Options
        //Their choice menu
        //Their Result.
      
        public void RunGame()
        {
            MainMenu();


        }

        public void MainMenu()
        {
            Console.WriteLine("Would you like the rules or start the game? (1) Rules | (2) Game Start");
            string userInput = Console.ReadLine();
            if(userInput == "1")
            {
                Rules();
            }
            else if (userInput == "2")
            {
                HowManyPeopleArePlayingMenu();
            }
        }

        public void Rules()
        {
            Console.WriteLine("");

        }

        public void HowManyPeopleArePlayingMenu()
        {
            
            Console.WriteLine("How many Playas?");
            string UserInput = Console.ReadLine();
            if (UserInput == "1")
            {
                Console.WriteLine("Hey Solo person, what's your name?");
                Player UserOne = new HumanPlayer;
                UserInput = Console.ReadLine();
                UserOne.name = UserInput;

                Console.WriteLine("A new player has joined.");

                Player UserTwo = new PlayerAI;
                UserTwo.name = "T3000";

            }
            else if (UserInput == "2")
            {
                Console.WriteLine("Two people, huh? what's your name?");
                UserInput = Console.ReadLine();
                UserOne.name = UserInput;

                Console.WriteLine("That's great, " + UserOne.name + "What's your pal's name?");
                UserInput = Console.ReadLine();
                UserTwo.name = UserInput;

            }
            else
            {
                HowManyPeopleArePlayingMenu();
            }
           
        }

        public void GestureMenu()
        {
            UserTwo.ChooseGesture(); // Will choose a random gesture
            UserOne.ChooseGesture(); // Will judge against that gesture
           
        }

        
        
    }
}
