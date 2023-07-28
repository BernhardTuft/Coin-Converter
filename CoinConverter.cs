using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Declare variables for coin values:
            int goldCoinValue = 10;
            int silverCoinValue = 5;

            Console.WriteLine("Welcome to coin converter!");

            Console.WriteLine("Enter an amount to convert to coins: ");
            string amountString = Console.ReadLine();

            // Attempt to convert user input to double using TryParse:
            if (double.TryParse(amountString, out double convertedAmount))
            {
                // Conversion successful:
                Console.WriteLine($"{convertedAmount} cents is equal to ...");

                // Calculate the change:
                int goldCoin = (int)(convertedAmount / goldCoinValue);
                int remainder = (int)(convertedAmount % goldCoinValue);

                int silverCoin = (int)(remainder / silverCoinValue);
                remainder = remainder % silverCoinValue;

                // Print the results
                Console.WriteLine($"Gold coins ({goldCoinValue} cents): {goldCoin}");
                Console.WriteLine($"Silver coins ({silverCoinValue} cents): {silverCoin}");
                Console.WriteLine($"Bronze coins: {remainder}");
            }
            else
            {
                // Conversion failed: 
                Console.WriteLine("Invalid input. Please enter a valid numeric value.");
                return; // Exit the program if conversion fails
            }
        }
    }
}
