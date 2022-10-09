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
                "answer if it is too low or too high.\n\tYou will have 10 tries and if you can't get the right number you will loose!");
            
            Console.WriteLine("Guess Your number!"); 
            int userNumber = Convert.ToInt32(Console.ReadLine()); //converting user's string input to int

            int randomNumber = new Random().Next(101); // it gives the random number from 0 to 100
            Console.WriteLine($"{randomNumber}");
            if (randomNumber == userNumber)
                Console.WriteLine("You win!");
            else if (randomNumber < userNumber)
                Console.WriteLine("Too High!");
            else if (randomNumber > userNumber)
                Console.WriteLine("Too Low!");
        }
    }
}