using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        private static bool CheckForExit(string inputText)
        {
            var isPlaying = !inputText.Equals("Q");
            if (!isPlaying)
            {
                Console.WriteLine("You chose to exit. Goodbye!");
                Environment.Exit(0);
            }

            return isPlaying;
        }

        static void Main(string[] args)
        {
            bool isPlaying;
            int count = 0;
            int operationMax = 2;
            bool chooseDifficulty = false;

            Random r = new Random();
            var theAnswer = r.Next(1, operationMax);

            Console.WriteLine("Press Q to quit.\n");

            // get player name
            Console.WriteLine("What is your name: ");
            var playerName = Console.ReadLine();
            CheckForExit(playerName);

            // get player's diffculty choice
            do
            {
                var easy = "easy";
                var normal = "normal";
                var hard = "hard";
                Console.WriteLine("Easy: 1-5");
                Console.WriteLine("Normal: 1-20");
                Console.WriteLine("Hard: 1-50");
                Console.WriteLine("\nChoose a mode to find the correct random number: ");
                var difficulty = Console.ReadLine().ToLower();

                if (difficulty == easy || difficulty == normal || difficulty == hard)
                {
                    chooseDifficulty = true;
                    switch (difficulty)
                    {
                        case "easy":
                            operationMax = 5;
                            theAnswer = r.Next(1, operationMax);
                            break;
                        case "normal":
                            operationMax = 20;
                            theAnswer = r.Next(1, operationMax);
                            break;
                        case "hard":
                            operationMax = 50;
                            theAnswer = r.Next(1, operationMax);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nInvalid choice, choose another difficulty.");
                }
            } while (chooseDifficulty == false);

            do
            {
                // get player input
                Console.Write($"\nEnter your guess (1-{operationMax}): ");
                var playerInput = Console.ReadLine();
                CheckForExit(playerInput);

                //attempt to convert the string to a number
                if (int.TryParse(playerInput, out var playerGuess))
                {
                    if (playerGuess >= 1 && playerGuess <= operationMax)
                    {
                        if (playerGuess == theAnswer)
                        {
                            if (count == 0)
                            {
                                Console.WriteLine($"Hey {playerName}, you guessed correctly on your first try! {theAnswer} was the number. You win!", Console.ForegroundColor = ConsoleColor.Green);
                                count++;
                                Console.WriteLine($"Attempts: {count}\n", Console.ForegroundColor = ConsoleColor.Gray);
                                Console.WriteLine("The game is over, press Q to quit.");
                            }
                            else
                            {
                                Console.WriteLine($"Hey {playerName}, {theAnswer} was the number. You win!", Console.ForegroundColor = ConsoleColor.Green);
                                count++;
                                Console.WriteLine($"Attempts: {count}\n", Console.ForegroundColor = ConsoleColor.Gray);
                                Console.WriteLine("The game is over, press Q to quit.");
                            }

                            while (Console.ReadKey().Key != ConsoleKey.Q)
                            {
                                Console.WriteLine("\nPress Q to quit");
                            }
                            isPlaying = false;
                        }
                        else
                        {
                            if (playerGuess > theAnswer)
                            {
                                Console.WriteLine($"Hey {playerName}, your guess was too high, try again.\n", Console.ForegroundColor = ConsoleColor.Red);
                                count++;
                                Console.WriteLine($"Attempts: {count}\n", Console.ForegroundColor = ConsoleColor.Gray);
                                isPlaying = CheckForExit(playerInput);
                            }
                            else
                            {
                                Console.WriteLine($"Hey {playerName}, your guess was too low, try again.\n", Console.ForegroundColor = ConsoleColor.Red);
                                count++;
                                Console.WriteLine($"Attempts: {count}\n", Console.ForegroundColor = ConsoleColor.Gray);
                                isPlaying = CheckForExit(playerInput);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Hey {playerName}, {playerGuess} is not in the range. Try again.\n", Console.ForegroundColor = ConsoleColor.Red);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        isPlaying = CheckForExit(playerInput);
                    }
                }
                else
                {
                    Console.WriteLine($"Hey {playerName}, you entered {playerGuess}, which is not a number!\n", Console.ForegroundColor = ConsoleColor.Red);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    isPlaying = CheckForExit(playerInput);
                }
            } while (isPlaying);
        }
    }
}