using System.Diagnostics.Metrics;

namespace number_guessing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {   //game introduction and rools
            Console.WriteLine("\n\t\t\t\t\tWelcome to 'Guess the number' game! \n\n\nRools are very simple:  " +
                "\n\tComputer will get the number and you must guess it." +
                "\n\tYou will enter a number and computer will give you " +
                "answer if it is too low or too high.\n\tYou will have 5 tries and if you can't get the right number you will loose!");
            int randomNumber = new Random().Next(101); // it gives the random number from 0 to 100
            Console.WriteLine($"{randomNumber}"); // Printing the random number to check how the IF statements reacting
             // this will be using to limit guesses

            for (int i = 4; i >= 0; i--) // this code is active until user gets right number or until it uses all 5 tries
            {
                Console.WriteLine("Guess Your number!");
                int userNumber = Convert.ToInt32(Console.ReadLine()); //converting user's string input to int

                int numberRange = userNumber - randomNumber; // count difference between user input number and random number
                if (randomNumber == userNumber)
                {
                    Console.WriteLine("You win! Left attempts {0}. Good job!", i);
                    return;
                }
                if (randomNumber < userNumber)
                {
                    if (-5 <= numberRange && numberRange <= 5) // user's number is lower up to 5 or higher up to 5 random number
                        Console.WriteLine("You are close! Left Tries {0}", i);
                       
                    Console.WriteLine("Too High! Left attempts {0}", i);

                }
                if (randomNumber > userNumber)
                {
                    if (-5 <= numberRange && numberRange <= 5) // user's number is lower up to 5 or higher up to 5 random number
                        Console.WriteLine("You are close! Left attempts {0}", i);
                        
                    Console.WriteLine("Too Low! Left attempts {0}", i);
                }
            }
            Console.WriteLine("You had too many attempts! Try again!");
        }
    }
}