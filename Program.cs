using System;
using System.Collections.Generic;

namespace Rock_Paper_Scissor
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string [] hands = { "Rock", "Paper", "Scissor" };
            Random numberGeneratorComputer = new Random();
           
            Console.WriteLine("Welcome to Rock, Paper, Scissor!");
            Console.WriteLine("Please write a number of how many rounds you want to play");
            int rounds = Convert.ToInt32(Console.ReadLine());
            
            
            int youPoints = 0;
            int computerPoints = 0;

        for (int countingPoints = 1; countingPoints <= rounds; countingPoints++)
        {
            
            Console.WriteLine("Do you choose Rock, Paper or Scissor?");
            string playerHand = Console.ReadLine();
            
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
                   computerPoints++;
                   Console.WriteLine("Computer wins!"); 
                } 
                else if (computerHand == "Scissor")
                {
                   youPoints++;
                   Console.WriteLine("You win!"); 
                }
                break;

                case "Paper":
                if (computerHand == "Rock")
                {
                   youPoints++; 
                   Console.WriteLine("You win!");  
                }
                else if (computerHand == "Paper")
                {
                   Console.WriteLine("It's a tie"); 
                } 
                else if (computerHand == "Scissor")
                {
                   computerPoints++;
                   Console.WriteLine("Computer wins!"); 
                }
                break;

                case "Scissor":
                if (computerHand == "Rock")
                {
                   youPoints++;
                   Console.WriteLine("You win!");  
                }
                else if (computerHand == "Paper")
                {
                   computerPoints++;
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

            Console.WriteLine("And the results are..");
            Console.WriteLine("Computer: " + computerPoints);
            Console.WriteLine("You: " + youPoints);

        }
    }
}
