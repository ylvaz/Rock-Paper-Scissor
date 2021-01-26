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
            
            int playerPoints = 0;
            int computerPoints = 0;
             
            Console.WriteLine("Computer rolled");
            Console.WriteLine(computerHand);



        }
    }
}
