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
        List<string> RPSLS = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };





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
            while(PlayerOne.scoreCount < 1 || PlayerTwo.scoreCount < 1)
            {
                CompareGestures();
          
            }    

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

        public void CompareGestures()
        {
            PlayerOne.ChooseGesture();
            PlayerTwo.ChooseGesture();

            string p1 = PlayerOne.ChosenGesture;
            string p2 = PlayerTwo.ChosenGesture;
            Console.WriteLine(PlayerOne.name + " has choosen " + p1 +".");
          
            if (p1 == p2)
            {
                Console.WriteLine("You read each other's mind!! AGAIN!!");
                Console.WriteLine(PlayerOne.scoreCount);
                Console.WriteLine(PlayerTwo.scoreCount);
                CompareGestures();

            }
            else if (p1 == "Rock"     && (p2 == "Scissors" || p2 == "Lizard")   ||
                     p1 == "Paper"    && (p2 == "Rock"     || p2 == "Spock")    ||
                     p1 == "Scissors" && (p2 == "Paper"    || p2 == "Lizard")   ||
                     p1 == "Lizard"   && (p2 == "Paper"    || p2 == "Spock")    ||
                     p1 == "Spock"    && (p2 == "Rock"     || p2 == "Scissors"))
                    
            {
                Console.WriteLine(PlayerOne.name + " wins this rind... on to the next rind. Good Luck, PARENTER");
                PlayerOne.scoreCount++;
                Console.WriteLine(PlayerOne.scoreCount);
                Console.WriteLine(PlayerTwo.scoreCount);
                CompareGestures();


            }
            else
            {
                PlayerOne.scoreCount++;
                Console.WriteLine(PlayerOne.scoreCount);
                Console.WriteLine(PlayerTwo.scoreCount);
                CompareGestures();

            }

        }

        public void CallingRock()
        {
            if (PlayerOne.ChosenGesture == PlayerTwo.RPSLS[2] || RPSLS[0] == RPSLS[3]) // wins against Scissors and Lizard
            {
                PlayerOne.scoreCount++;
            }

            else if (RPSLS[0] == RPSLS[1] || RPSLS[0] == RPSLS[1]) // loses against Paper and Spock
            {
                PlayerTwo.scoreCount++;
            }
            else if (RPSLS[0] == RPSLS[0]) // ties itself
            {
                CompareGestures();
            }
            else
            {
                CompareGestures();
            }

        }

        public void CallingPaper()
        {
            if (RPSLS[1] == RPSLS[0] || RPSLS[1] == RPSLS[5]) // wins against rock and Spock
            {
                PlayerOne.scoreCount++;
            }

            else if (RPSLS[1] == RPSLS[2] || RPSLS[1] == RPSLS[3]) //loses against Scissors + Lizard
            {
                PlayerTwo.scoreCount++;
            }

            else if (RPSLS[1] == RPSLS[1]) // ties itself
            {
                CompareGestures();

            }
            else
            {
                CompareGestures();

            }

        }
        public void CallingScissors()
        {
            // PlayerTwo.ChooseGesture()
            if (RPSLS[2] == RPSLS[1] || RPSLS[2] == RPSLS[3]) // wins against Paper and Lizard
            {
                PlayerOne.scoreCount++;
            }

            else if (RPSLS[2] == RPSLS[0] || RPSLS[2] == RPSLS[4]) // loses against Rock and Spock
            {
                PlayerTwo.scoreCount++;
            }
            else if (RPSLS[2] == RPSLS[2]) // ties itself 
            {
                CompareGestures();
            }
            else
            {
                CompareGestures();
            }

        }

        public void CallingLizard()
        {
            if (RPSLS[3] == RPSLS[1] || RPSLS[3] == RPSLS[4]) // wins against paper + Spock
            {
                PlayerOne.scoreCount++;
            }

            else if (RPSLS[3] == RPSLS[0] || RPSLS[3] == RPSLS[2]) //loses against Rock + Scissors
            {
                PlayerTwo.scoreCount++;
            }
            else if (RPSLS[3] == RPSLS[3]) // ties itself 
            {
                CompareGestures();
            }
            else
            {
                CompareGestures();
            }
        }


        public void CallingSpock()
        {
            if (RPSLS[4] == RPSLS[0] || RPSLS[4] == RPSLS[2]) // wins against Rock and Scissors
            {
                PlayerOne.scoreCount++;
            }

            else if (RPSLS[4] == RPSLS[1] || RPSLS[4] == RPSLS[3]) // loses against Paper + Lizard
            {
                PlayerTwo.scoreCount++;
            }
            else if (RPSLS[4] == RPSLS[4]) // ties itself
            {
                CompareGestures();
            }
            else
            {
                CompareGestures();
            }
        }
    }
}
