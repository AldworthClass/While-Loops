using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            Console.WriteLine("PIN Example from lesson");
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            PINExample();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Count Example from lesson");
            Console.WriteLine("-------------------------");
            CountExample();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Task 1 - Bad Guessing Game");
            Console.WriteLine("--------------------------");
            Task1BadGuessingGame(generator);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Task 2 - Dice Doubles");
            Console.WriteLine("---------------------");
            Task2DiceDoubles(generator);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Task 3 - Adding Numbers in a Loop");
            Console.WriteLine("---------------------------------");
            Task3AddingNumbersInLoop();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Hit ENTER to quit");
            Console.ReadLine();
        }

        // Completed PIN example from lesson including suggestions.
        public static void PINExample()
        {
            int pin = 12345;
            int entry;
            int tries = 0;
            int maxTries = 4;   // Using a variable allows us to chang the maximum number of tries just here, and it will apply to the rest of the program.

            Console.WriteLine("WELCOME TO THE BANK OF ALDWORTH.");
            Console.WriteLine("ENTER YOUR PIN (" + (maxTries - tries) + " attempts left):");
            entry = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            tries++;

            while (entry != pin && tries < maxTries)
            {
                Console.WriteLine("INCORRECT PIN. TRY AGAIN.");
                Console.WriteLine("ENTER YOUR PIN:(" + (maxTries - tries) + " attempts left):");
                entry = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                tries++;
            }

            if (entry == pin)
                Console.WriteLine("PIN ACCEPTED. YOU NOW HAVE ACCESS.");
            else if (tries >= maxTries)
                Console.WriteLine("YOU HAVE RUN OUT OF TRIES.  ACCOUNT LOCKED.");
        }

        // Completed Counter example from lesson with some suggestions.
        public static void CountExample()
        {
            string message;
            int count = 0;
            int repetitions;

            Console.WriteLine("Type in a message, and I'll display it several times.");
            Console.WriteLine("Message: ");
            message = Console.ReadLine();
            Console.WriteLine("How many times? ");
            repetitions = Convert.ToInt32(Console.ReadLine());

            while (count < repetitions) 
            {
                Console.WriteLine((count + 1) + ". " + message);
                count ++;    
            }
        }

        // Solutions for Task 1 - Bad Guessing Game
        public static void Task1BadGuessingGame(Random generator)
        {

            int guess = 0, secretNumber;
            secretNumber = generator.Next(1, 11);

            while (guess != secretNumber)
            {
                Console.WriteLine("Please guess the secret number.  It could be anything from 1 to 10.");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess == secretNumber)
                    Console.WriteLine("Congradulations, you guessed it!!");  // Since there is only 1 line of code in the if statement we don't need the brackets {}
                else
                    Console.WriteLine("Sorry but no.");
                Console.WriteLine(); // Not in the else state,ent
            }
        }

        // Solutions for Task 2 - Dice Doubles
        public static void Task2DiceDoubles(Random generator)
        {
            int num1 = 1, num2 = 0;  // I made num1 and num2 different values so we get into the loop at least once
            int total;

            Console.WriteLine("Hit ENTER to roll the dice.");
            Console.ReadLine();       
            while (num1 != num2)
            {
                num1 = generator.Next(1, 7);
                num2 = generator.Next(1, 7);
                total = num1 + num2;
                Console.WriteLine("Die 1 - " + num1);
                Console.WriteLine("Die 2 - " + num2);
                Console.WriteLine("Total - " + total);
                Console.WriteLine();
            }           
        }

        // Task 3 - Adding Numbers in a loop
        public static void Task3AddingNumbersInLoop()
        {
            int total = 0;
            int count = 0;
            int numbers = 5; // User will enter this many numbers.
            int input;

            Console.WriteLine("You will be prompted to enter 5 numbers and I will add them for you.");
            while (count < numbers)
            {
                Console.WriteLine("Please enter a number:");
                input = Convert.ToInt32(Console.ReadLine());
                total += input; // Adds the entered number to the running total
                count++; // Increases our counter so we know how many values have been read in
            }
            Console.WriteLine();
            Console.WriteLine("The total is: " + total);
        }
    }
}