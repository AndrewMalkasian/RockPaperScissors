using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {
        Player PlayerOne;
        Player PlayerTwo;
        

        

        
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
            GestureMenu();


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
                 PlayerOne = new PlayerHuman();
                PlayerOne.name = Console.ReadLine();
                

                Console.WriteLine("A new player has joined. T3000 is his name.");

                PlayerTwo = new PlayerAI();
                PlayerTwo.name = "T3000";

            }
            else if (UserInput == "2")
            {
                PlayerOne = new PlayerHuman();
     
                Console.WriteLine("Two people, huh? what's YOUR name?");
                PlayerOne.name = Console.ReadLine();
                

                PlayerTwo = new PlayerHuman();
                Console.WriteLine("That's great, " + PlayerOne.name + "What's your pal's name?");
                PlayerTwo.name = Console.ReadLine();
               

            }
            else
            {
                HowManyPeopleArePlayingMenu();
            }
           
        }

        public void GestureMenu()
        {
            PlayerOne.ChooseGesture();
            PlayerTwo.ChooseGesture();

        }

        
        
    }
}
