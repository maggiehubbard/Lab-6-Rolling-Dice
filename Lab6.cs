using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_Dice_Rolling
{
    
    class Program
    {
        public static Random rnd = new Random();

        static int rollDice(int s)
        {
            int result = rnd.Next(1,s);
            return result;
            
        }


        static void Main(string[] args)
        {
            //declare variables
            string response = "y";
            string sidesS;
            int sidesI; 
            bool isItANum; //for my TryParse
            int again = 1; //counter

            Console.Write("Welcome to the Grand Circus Casino! Roll the dice? (y/n): ");

            

                response = Console.ReadLine().ToLower();
            while (response == "y")
            {
                //user prompts
                Console.Write("How many sides should each die have? ");
                sidesS = Console.ReadLine();
                isItANum = int.TryParse(sidesS, out sidesI);
                while (!isItANum)
                {
                    //catches characters that are not numbers
                    Console.Write("Error the number you entered was invalid. Would you like to try again? (y/n)");
                    response = Console.ReadLine().ToLower();
                    Console.Write("How many sides should each die have? ");
                    sidesS = Console.ReadLine();
                    isItANum = int.TryParse(sidesS, out sidesI);
                    
                }


                
                string input = "y";

                //output               
                Console.WriteLine("Roll " + again);
                Console.WriteLine(rollDice(sidesI));
                Console.WriteLine(rollDice(sidesI));
                

                //asks user is they want to play again
                Console.WriteLine("\nRoll again? (y/n)");
                input = Console.ReadLine().ToLower();
                if (input != "y")
                {
                    response = "n";
                }
                again++;




            }
            //pause before close
            Console.WriteLine("Press any key to exit . .");
            Console.ReadKey();
            
        }
    }
}
