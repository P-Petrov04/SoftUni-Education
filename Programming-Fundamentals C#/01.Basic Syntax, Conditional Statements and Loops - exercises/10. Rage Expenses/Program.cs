using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfLostGames = int.Parse(Console.ReadLine());
            double headset = double.Parse(Console.ReadLine());
            double mouse = double.Parse(Console.ReadLine());
            double keyboard = double.Parse(Console.ReadLine());
            double display = double.Parse(Console.ReadLine());

            int headsetTrashed = countOfLostGames / 2;
            int mouseTrashed = countOfLostGames / 3;
            int keyboardTrashed = countOfLostGames / 6;
            int displayTrashed = countOfLostGames / 12;

            double totalPrice = headsetTrashed * headset + mouseTrashed * mouse + keyboardTrashed * keyboard + displayTrashed * display;

            Console.WriteLine($"Rage expenses: {totalPrice:f2} lv.");
        }
    }
}
