using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Random rnd = new Random();

            int firstDice, secondDice = 0;
            int playerScore = 0, pcScore = 0, localScore = 0;

            void roundGoing(string a, string b)
            {
                firstDice = rnd.Next(1,7);
                secondDice = rnd.Next(1,7);
                Console.WriteLine($"It's {a} turn!");
                Thread.Sleep(1000);
                Console.WriteLine("Dices thrown!");
                Console.WriteLine($"First dice is {firstDice}\n" + $"Second dice is {secondDice}");
                localScore = firstDice + secondDice;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{b} got {localScore} in this round!");
                Console.ResetColor();
                Console.WriteLine("-----------------------------------------");
                Thread.Sleep(2000);
            }

            bool isPlayerTurn = rnd.Next(2) == 0;
            Console.WriteLine(isPlayerTurn ? "You are starting the game!" : "Computer is starting the game!");

            for (int rounds = 1; rounds <= 4; rounds++) {
                Console.WriteLine($"Round {rounds}!");

                if (isPlayerTurn) 
                { 
                    roundGoing("your", "You");
                    playerScore = playerScore + localScore;
                }
                else 
                { 
                    roundGoing("computer's", "Computer");
                    pcScore = pcScore + localScore;
                };

                isPlayerTurn = !isPlayerTurn;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Final results: ");
            Console.ResetColor();
            Console.WriteLine($"You have {playerScore} points!");
            Console.WriteLine($"Computer has {pcScore} points!");
            if (playerScore > pcScore)
            {
                Console.WriteLine("You won!");
            } else if (pcScore > playerScore) {
                Console.WriteLine("You lose!");
            } else { Console.WriteLine("Tie!"); }

            Console.WriteLine("Submit any key to exit");
            Console.ReadLine();
        }
    }
}
