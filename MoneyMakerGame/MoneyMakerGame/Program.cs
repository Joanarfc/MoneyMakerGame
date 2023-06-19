using System;

namespace MoneyMakerGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");

            double amount = ReadValidAmount();

            if (amount != -1)
            {
                Console.WriteLine($"{amount} cents is equal to...");

                int goldCoin = 10;
                int silverCoin = 5;

                double goldCoins = Math.Floor(amount / goldCoin);
                double remainder = amount % goldCoin;

                double silverCoins = Math.Floor(remainder / silverCoin);
                remainder = amount % silverCoin;

                Console.WriteLine($"Gold coins: {goldCoins}");
                Console.WriteLine($"Silver coins: {silverCoins}");
                Console.WriteLine($"Bronze coins: {remainder}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid amount.");
            }

            Console.ReadLine();
        }

        static double ReadValidAmount()
        {
            Console.WriteLine("Enter the amount of money you wish to convert:");
            if (double.TryParse(Console.ReadLine(), out double amount))
            {
                return amount;
            }
            else
            {
                return -1;
            }
        }
    }
}
