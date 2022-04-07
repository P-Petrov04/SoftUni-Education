using System;

namespace _06.Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double pointsAcademy = double.Parse(Console.ReadLine());
            int evaluators = int.Parse(Console.ReadLine());

            

            for (int i = 1; i <= evaluators; i++)
            {
                string evaluator = Console.ReadLine();
                double points = double.Parse(Console.ReadLine());

                pointsAcademy += (evaluator.Length * points / 2);

                if(pointsAcademy >= 1250.5)
                {
                    break;
                }
            }
            if (pointsAcademy >= 1250.5)
            {
                Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {pointsAcademy:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {actor} you need {(1250.5 - pointsAcademy):f1} more!");
            }
        }
    }
}
