using System;

namespace _03._Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            bool isEqual = true;
            double diff = Math.Abs(firstNum - secondNum);
            if (diff >= 0.000001)
            {
                isEqual = false;
            }
            Console.WriteLine(isEqual);
        }
    }
}
