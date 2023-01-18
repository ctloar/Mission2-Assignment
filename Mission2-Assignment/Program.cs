using System;

namespace Mission2_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introduction to the game
            Console.WriteLine("Welcome to the dice rolling game!\n\nHow many dice rolls would you like to simulate?");

            // Initialize the variables needed to play the game
            int iNumRolls = int.Parse(Console.ReadLine());
            int[] iResults = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Random rnd = new Random();
           
            // Executes logic for every roll based on the number of rolls specified by user
            // Generates a random number for each roll, and adds/updates that roll into the array of results
            for (int i=1; i<=iNumRolls; i++)
            {
                int iRoll = rnd.Next(2,13);
                iResults[iRoll-2] += 1;
            }

            Console.WriteLine("The following results represent percentages:\n");

            // Outer loop iterates through each possible outcome (12) to add logic (the count of rolls that added to that number)
            for (int i=0; i<11; i++)
            {
                string output = "";
                output = (i + 2) + ": ";

                // Inner loop iterates through each result value in the results array, calculates the percentage value,
                // and concatenates * to the output
                for (int j=0; j< (int)((iResults[i] / (double)iNumRolls) * 100); j++)
                {
                    output = output + "*";
                }
                Console.WriteLine(output);
                
            }
        }
    }
}
