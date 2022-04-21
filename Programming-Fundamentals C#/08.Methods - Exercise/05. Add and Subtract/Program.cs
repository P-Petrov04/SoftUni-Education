using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int sum = SumOfNum1AndNum2(num1, num2);

            int finalResult = SubtractNum3FromSum(sum, num3);
            Console.WriteLine(finalResult);
        }
        static int SumOfNum1AndNum2 (int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        static int SubtractNum3FromSum (int sum, int num3)
        {
            int subtract = sum - num3;
            return subtract;
        }
    }
}
