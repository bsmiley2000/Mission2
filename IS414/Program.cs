using System;
using System.Linq;

class DiceGame
{
    static void Main()
    {

        int[] results = new int[13]; // An array that will keep track of the total for each roll
        int rollCount; // number of times the dice are rolled
        Random rng = new Random(); 

        Console.WriteLine("Welcome to the dice throwing simulator! \n \n " );
        Console.Write("How many dice rolls would you like to simulate?: ");
        rollCount = int.Parse(Console.ReadLine());

        // Dice rolls
        for (int i = 0; i < rollCount; i++)
        {
            int dice1 = rng.Next(1, 7); // Dice 1
            int dice2 = rng.Next(1, 7); // Dice 2
            int total = dice1 + dice2; // Total of the two dices
            results[total]++; // add the results to the array and increment 
        }

        Console.WriteLine("\n\nDICE ROLLING SIMULATION RESULTS  \nEach '*' represents 1 % of the total number of rolls. \nTotal number of rolls = " + rollCount + ".");


        // Print the histogram with the * marks
        for (int i = 2; i <= 12; i++)
        {
            double percentage = (double)results[i] / rollCount * 100; 
            Console.Write(i + ": ");
            for (int j = 0; j < percentage; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\n\nThank you for using the dice throwing simulator. Goodbye!");


#if DEBUG // How to exit the console once the game is over
        try
        {
            //...
        }
        finally
        {
            Console.WriteLine("\n\n\nPress enter to close...");
            Console.ReadLine();
        }
        #endif
    }
}
