using System;
using System.Collections.Generic;

namespace Rock_Paper_Scissor
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Welcome to Rock, paper, scissor!");

            string [] hands = { "Rock", "Paper", "Scissor" };
            Console.WriteLine("Do you choose rock, paper or scissor?");
            string playerHand;
            playerHand = Console.ReadLine();
            Random numberGeneratorComputer = new Random();
            int randomNumber = numberGeneratorComputer.Next(0,3);
            string computerHand = hands[randomNumber];
             
            Console.WriteLine("Computer rolled...");
            Console.WriteLine(computerHand);

            switch (playerHand && computerHand)
            {
                
                case "Rock" + "Rock":
                Console.WriteLine("It's a tie");
                break;

                default:
            }



        }
    }
}
