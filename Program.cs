using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project12
{
    class Program
    {
        static void Main(string[] args)
        {
            string player_name;
            double balance;
            double betting_amount;
            int guess;
            int contain;
            char choice;

            Console.WriteLine("\t\t\t\t********************WELCOME TO CASINO GAME********************");
            Console.WriteLine("\n");
            Console.Write("Enter the player name : ");
            player_name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter the starting balance from which you want to start the Game : $");
            balance = double.Parse(Console.ReadLine());
            Console.WriteLine();
            do
            {
                rules();
                Console.WriteLine();
                Console.WriteLine($"Hello, {player_name} your current balance is ${balance}\n");


                do
                {
                    Console.Write($"{player_name} enter amount to bet : $");
                    betting_amount = double.Parse(Console.ReadLine());
                    if (betting_amount > balance)
                    {
                        Console.WriteLine("Betting balance can't be more than current balance!");
                    }
                } while (betting_amount > balance);

                do
                {
                    Console.Write("Guess any number between 1 - 10 for betting : ");
                    guess = int.Parse(Console.ReadLine());
                    if (guess <= 0 || guess > 10)
                    {
                        Console.WriteLine("\n-->> NOTE : Gussing number should be between 1 - 10");
                    }
                } while (guess <= 0 || guess > 10);

                Random rnd = new Random();
                contain = rnd.Next(10);
                if (guess == contain)
                {
                    Console.WriteLine($"OMG you are lucky :) you won ${betting_amount * 10}");
                    balance = balance + betting_amount;
                }
                else
                {
                    Console.WriteLine($"\nOops, Better Luck next time :( you Lost ${betting_amount}");
                    balance = balance - betting_amount;
                }
                Console.WriteLine($"\nWinning number was : {contain}");
                Console.WriteLine();
                Console.WriteLine($"{player_name} Now you have ${balance}");
                if (balance == 0)
                {
                    Console.WriteLine("No money left :( ");  
                    Console.WriteLine("\nEarn more money and come again next time ");
                    Console.WriteLine("\nThanks for playing");
                    Console.ReadLine();
                    break;
                }
                Console.WriteLine("\n--->> Want to play again (Y/N) ");
                choice = char.Parse(Console.ReadLine());

            } while (choice == 'Y' || choice == 'y');
            Console.WriteLine($"\nThanks {player_name} for playing . your balance is ${balance}");

        }
        static void rules()
        {
            Console.WriteLine("\t\t\t\t================CASINO NUMBER GUESSING RULES!================");
            Console.WriteLine();
            Console.WriteLine("\t1. Choose a number between 1 to 10");
            Console.WriteLine("\t2. Winner gets 10 times of the money bet");
            Console.WriteLine("\t3. Wrong bet, and you lose the amount you bet");
        }

    }
}