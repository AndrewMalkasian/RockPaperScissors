using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Exceptions
    {
        public string UserInput;
        public Exceptions()
        {



        }

        public void UserInputValidation()
        {
            if(UserInput == null)
            { 
                Console.WriteLine("Wrong Input. Try again.");

            }


        }






    }
}
