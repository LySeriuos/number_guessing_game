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
            int userNumber;
             
            // this will be using to limit guesses
            for (int i = 4; i >= 0; i--) // this code is active until user gets right number or until it uses all 5 tries
            {
                Console.WriteLine("Guess Your number!");
                userNumber = Convert.ToInt32(Console.ReadLine()); //converting user's string input to int
                
                if (randomNumber == userNumber)
                {
                    Console.WriteLine($"You win! Left attempts {i}. Good job!");
                    return; // quiting the for loop if the user input is equal to random number
                }
                // i >= 1 is to filter output after the last try, user will get only "Try again!" output instead of all possible
                if (randomNumber < userNumber && i >= 1) // if the random number is lower than user's input number and {i} is bigger than 1
                {    
                    Console.WriteLine($"Too High! Left attempts: {i}");
                }

                if (randomNumber > userNumber && i >= 1) // if the random number is higher than user's input number
                {    
                    Console.WriteLine($"Too Low! Left attempts: {i}");
                }

                if (Math.Abs(userNumber - randomNumber) <=5 && i >= 1) // if user's number is lower up to 5 or higher up to 5 random number
                {
                    Console.WriteLine($"You are close!");
                }
            }
            Console.WriteLine("You had too many attempts! Try again!");
            Console.WriteLine($"The Right Number: {randomNumber}"); // Function will show randomNumber for player after all attempts was used
        }
    }
}