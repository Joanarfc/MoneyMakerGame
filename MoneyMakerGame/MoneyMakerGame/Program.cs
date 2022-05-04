using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMakerGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");

            Console.WriteLine("Enter the amount of money you wish to convert:");
            double amount = Convert.ToDouble(Console.ReadLine());
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
    }
}
