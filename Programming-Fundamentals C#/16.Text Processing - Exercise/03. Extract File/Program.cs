using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathToAFile = Console.ReadLine();

            int startingIndexOfTheFileName = pathToAFile.LastIndexOf('\\');
            int endingIndexOfTheFileName = pathToAFile.IndexOf('.');

            string fileName = pathToAFile.Substring(startingIndexOfTheFileName + 1, endingIndexOfTheFileName -
                startingIndexOfTheFileName - 1);
            string extension = pathToAFile.Substring(endingIndexOfTheFileName + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");

        }
    }
}
