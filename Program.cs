using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomnumber = new Random();
           
            int ReturnValue = randomnumber.Next(1, 10);
            int Guess = 0;
            int NumGuess = 0;

            Console.WriteLine("Guess a Number Between 1-10: "); //Ask user to choose between 1-10

            while (ReturnValue != Guess) //Value not the same with Guess
            {
                NumGuess++;
                Guess = Convert.ToInt32(Console.ReadLine());

                if (Guess < ReturnValue) //If Guess lower than Value
                {
                    Console.WriteLine($"Im thinking more higher than {Guess}");
                }
                else if (Guess > ReturnValue) //If Guess higher than Value
                {
                    Console.WriteLine($"Im thinking more lower than {Guess}");

                }
                else if (Guess == ReturnValue) //If Guess equal to Value
                {
                    Console.WriteLine($"That's correct, You took {NumGuess} guesses");
                    Console.ReadLine();
                }
                if (NumGuess > 3) //Game Over
                {
                    Console.WriteLine($"Sorry you ran out of guesses");
                    Console.WriteLine($"It's {ReturnValue}!");
                    Console.ReadLine();
                }
            }
           
        }
    }
}
