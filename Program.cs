using System;
using System.Collections.Generic;

namespace Rock_Paper_Scissor
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Welcome to Rock, Paper, Scissor!");

            string [] hands = { "Rock", "Paper", "Scissor" };
            Console.WriteLine("Do you choose Rock, Paper or Scissor?");
            string playerHand;
            playerHand = Console.ReadLine();
            Random numberGeneratorComputer = new Random();
            int randomNumber = numberGeneratorComputer.Next(0,3);
            string computerHand = hands[randomNumber];
             
            Console.WriteLine("Computer rolled...");
            Console.WriteLine(computerHand);

            switch (playerHand)
            {
                
                case "Rock":
                if (computerHand == "Rock")
                {
                   Console.WriteLine("It's a tie");  
                }
                else if (computerHand == "Paper")
                {
                   Console.WriteLine("Computer wins!"); 
                } 
                else if (computerHand == "Scissor")
                {
                   Console.WriteLine("You win!"); 
                }
                break;

                case "Paper":
                if (computerHand == "Rock")
                {
                   Console.WriteLine("You win!");  
                }
                else if (computerHand == "Paper")
                {
                   Console.WriteLine("It's a tie"); 
                } 
                else if (computerHand == "Scissor")
                {
                   Console.WriteLine("Computer wins!"); 
                }
                break;

                case "Scissor":
                if (computerHand == "Rock")
                {
                   Console.WriteLine("You win!");  
                }
                else if (computerHand == "Paper")
                {
                   Console.WriteLine("Computer wins!"); 
                } 
                else if (computerHand == "Scissor")
                {
                   Console.WriteLine("It's a tie"); 
                }
                break;
    

  
                default:
                break;
            }



        }
    }
}
