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
        //Their Result.1


        public void RunGame()
        {
            MainMenu();

         //make a variable for # of rounds
            while(true)
                if(PlayerOne.scoreCount >= 2 || PlayerTwo.scoreCount >= 2)
                {
                GameWinner();
                }
                else if (PlayerOne.scoreCount < 2 || PlayerOne.scoreCount < 2)
                {
               
                CompareGestures();
                }
                else
                {
                    break;
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
            Console.WriteLine("RULES TO RPSLS: ROCK, PAPER, SCISSORS, LIZARD, SPOCK");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("WIN CONDITION: In a best of three match, crush the spirit of your opponent by flailing your hand effortlessly towards them synchronously!");
            Console.WriteLine("SCORING: ");
            Console.WriteLine("Get a point by craftily manipulating your hand: ");
            Console.WriteLine("ROCK    BEATS: Scissors and  Lizards   |  ROCK     LOSES: Spock    and  Paper.  ");
            Console.WriteLine("PAPER   BEATS: Rock     and  Spock     |  PAPER    LOSES: Scissors and  Lizard. ");
            Console.WriteLine("SCISSOR BEATS: Paper    and  Lizards   |  SCISSORS LOSES: Rock     and  Spock   ");
            Console.WriteLine("LIZARD  BEATS: Paper    and  Spock     |  LIZARD   LOSES: Rock     and  Scissors");
            Console.WriteLine("SPOCK   BEATS: Rock     and  scissors  |  SPOCK    LOSES: Paper    and  Lizard  ");
            Console.WriteLine("Return to the main menu? (1) | Support my grade by playing my game. (2) | Hear the rules again (3)");
           string UserInput = Console.ReadLine();
            if (UserInput == "1" || UserInput == "2")
            {
                HowManyPeopleArePlayingMenu();

            }            
            else if(UserInput == "3")

                Console.WriteLine("You already read the rules...");
                HowManyPeopleArePlayingMenu();
 
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
            
            if (p1 == p2)
            {
                Console.WriteLine($"{PlayerOne.name} and {PlayerTwo.name} have both chosen {p1}");
                Console.WriteLine($"{PlayerOne.name} : {PlayerOne.scoreCount}");
                Console.WriteLine($"{PlayerTwo.name} : {PlayerTwo.scoreCount}");
               

            }
            else if (p1 == "Rock"     && (p2 == "Scissors" ||  p2 == "Lizard")    ||
                     p1 == "Paper"    && (p2 == "Rock"     ||  p2 == "Spock")     ||
                     p1 == "Scissors" && (p2 == "Paper"    ||  p2 == "Lizard")    ||
                     p1 == "Lizard"   && (p2 == "Paper"    ||  p2 == "Spock")     ||
                     p1 == "Spock"    && (p2 == "Rock"     ||  p2 == "Scissors"))
            {
                Console.WriteLine($"{PlayerOne.name}   wins this round...");
                PlayerOne.scoreCount++;
                Console.WriteLine($"{PlayerOne.name} : {PlayerOne.scoreCount}");
                Console.WriteLine($"{PlayerTwo.name} : {PlayerTwo.scoreCount}");
            }
            else
            {
                Console.WriteLine($"{PlayerOne.name}   wins this round...");
                PlayerTwo.scoreCount++;
                Console.WriteLine($"{PlayerOne.name} : {PlayerOne.scoreCount}");
                Console.WriteLine($"{PlayerTwo.name} : {PlayerTwo.scoreCount}");

            }

        }

        public void GameWinner()
        {
            Console.WriteLine("You won. Would you like to play again? (y) | (n)");
           string UserInput = Console.ReadLine();
            if (UserInput == "y")
            {
                MainMenu();
            }
            else
            {
                Console.WriteLine("Thank you, come again!");
            }
        }

    }
}
