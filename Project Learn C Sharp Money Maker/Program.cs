using System;

namespace Project_Learn_C_Sharp_Money_Maker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Intro
            Console.WriteLine("Welcome to Money Maker!");

            // 2
            Console.WriteLine("Enter an amount to convert to coins: ");
            string convert = Console.ReadLine();

            // 3

               double convert2 = Convert.ToDouble(convert);
               Console.WriteLine($"{convert}  cents is equal to...");

            // 6

            int goldValue = 10;
            int silverValue = 5;

            // 7
            double goldCoins = Math.Floor(convert2 / 10);

            // 8
            double leftOver = convert2 % 10;

            // 9
            Double silverCoins = Math.Floor(leftOver / silverValue);

            // 10
            leftOver = leftOver % silverValue;

            // 11

            Console.WriteLine($"Gold Coins {goldCoins} Silver Coins {silverCoins}");





















        }
    }
}
