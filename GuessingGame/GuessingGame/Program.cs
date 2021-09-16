using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int theAnswer;
            int playerGuess;
            string playerInput;
            string playerName;

            Random r = new Random();
            theAnswer = r.Next(1, 21);

            do
            {
                Console.WriteLine("What is your name: ");
                playerName = Console.ReadLine();

                // get player input
                Console.Write("\nEnter your guess (1-20): ");
                playerInput = Console.ReadLine();

                //attempt to convert the string to a number
                if (int.TryParse(playerInput, out playerGuess))
                {
                    if (playerGuess >= 1 && playerGuess <= 20)
                    {
                        if (playerGuess == theAnswer)
                        {
                            Console.WriteLine($"Hey {playerName}, {theAnswer} was the number. You win!");
                            break;
                        }
                        else
                        {
                            if (playerGuess > theAnswer)
                            {
                                Console.WriteLine($"Hey {playerName}, your guess was too high, try again.\n");
                            }
                            else
                            {
                                Console.WriteLine($"Hey {playerName}, your guess was too low, try again.\n");
                            }
                        }
                    }
                    else 
                    {
                        Console.WriteLine($"Hey {playerName}, {playerGuess} is not in the range. Try again.\n");
                    }
                }
                else
                {
                    Console.WriteLine($"Hey {playerName}, you entered {playerGuess}, which is not a number!\n");
                }

            } while (true);

            Console.WriteLine("Press any key to quit.");
            Console.ReadKey();
        }
    }
}
