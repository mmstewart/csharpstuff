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
            int count = 0;

            Random r = new Random();
            var theAnswer = r.Next(1, 21);
            Console.WriteLine("Press Q to quit.\n");

            // get player name
            Console.WriteLine("What is your name: ");
            var playerName = Console.ReadLine();
            CheckForExit(playerName);

            Console.WriteLine($"\n{theAnswer}");

            bool isPlaying;
            do
            {
                // get player input
                Console.Write("\nEnter your guess (1-20): ");
                var playerInput = Console.ReadLine();
                CheckForExit(playerInput);

                //attempt to convert the string to a number
                if (int.TryParse(playerInput, out var playerGuess))
                {
                    if (playerGuess >= 1 && playerGuess <= 20)
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

                            Console.ReadKey();
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
