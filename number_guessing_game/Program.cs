﻿using System.Diagnostics.Metrics;

namespace number_guessing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t\t\t\t\tWelcome to 'Guess the number' game! \n\n\nRools are very simple:  " +
                "\n\tComputer will get the number and you must guess it." +
                "\n\tYou will enter a number and computer will give you " +
                "answer if it is too low or too high.\n\tYou will have 10 tries and if you can't get the right number you will loose!");
        }
    }
}