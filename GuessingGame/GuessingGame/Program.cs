using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        private static void CheckForExit(string inputText)
        {
            if (inputText.Equals("Q"))
            {
                Console.WriteLine("You chose to exit. Goodbye!");
                Environment.Exit(0);
            }
        }

        static void Main(string[] args)
        {
            int theAnswer,
                playerGuess,
                count = 0;
            string playerInput,
                playerName;

            Random r = new Random();
            theAnswer = r.Next(1, 21);
            Console.WriteLine("Press Q to quit.\n");

            // get player name
            Console.WriteLine("What is your name: ");
            playerName = Console.ReadLine();
            CheckForExit(playerName);

            //Console.WriteLine($"\n{theAnswer}");

            do
            {
                // get player input
                Console.Write("\nEnter your guess (1-20): ");
                playerInput = Console.ReadLine();
                CheckForExit(playerInput);

                //attempt to convert the string to a number
                if (int.TryParse(playerInput, out playerGuess))
                {
                    if (playerGuess >= 1 && playerGuess <= 20)
                    {
                        if (playerGuess == theAnswer)
                        {
                            if (count == 0)
                            {
                                Console.WriteLine($"Hey {playerName}, you guessed correctly on your first try! {theAnswer} was the number. You win!");
                                count++;
                                Console.WriteLine($"Attempts: {count}\n");
                                Console.WriteLine("The game is over, press Q to quit.");
                                CheckForExit(playerInput);
                            }
                            else 
                            {
                                Console.WriteLine($"Hey {playerName}, {theAnswer} was the number. You win!");
                                count++;
                                Console.WriteLine($"Attempts: {count}\n");
                                Console.WriteLine("The game is over, press Q to quit.");
                                CheckForExit(playerInput);
                            }
                        }
                        else
                        {
                            if (playerGuess > theAnswer)
                            {
                                Console.WriteLine($"Hey {playerName}, your guess was too high, try again.\n");
                                count++;
                                Console.WriteLine($"Attempts: {count}\n");
                                CheckForExit(playerInput);
                            }
                            else
                            {
                                Console.WriteLine($"Hey {playerName}, your guess was too low, try again.\n");
                                count++;
                                Console.WriteLine($"Attempts: {count}\n");
                                CheckForExit(playerInput);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Hey {playerName}, {playerGuess} is not in the range. Try again.\n");
                        CheckForExit(playerInput);
                    }
                }
                else
                {
                    Console.WriteLine($"Hey {playerName}, you entered {playerGuess}, which is not a number!\n");
                    CheckForExit(playerInput);
                }

            } while (true);
        }
    }
}
