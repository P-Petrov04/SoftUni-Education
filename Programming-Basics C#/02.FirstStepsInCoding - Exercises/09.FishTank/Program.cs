using System;

namespace _09.FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percents = double.Parse(Console.ReadLine());

            //обем на аквариумa: 85 * 75 * 47 = 299625 см3
            //обем в литри: 299625 * 0.001 или  299625 / 1000 => 299.625 литра
            //заето пространство: 17 % = 0.17
            //нужни литри: 299.625 * (1 - 0.17) = 248.68875 литра
            double vCM = length * width * height;
            double vL = vCM * 0.001;
            double percentsL = percents * 0.01;
            double L = vL * (1 - percentsL);

            Console.WriteLine(L);
        }
    }
}
