using System;
using System.Collections.Generic;

namespace _03._Songs
{
    class Song
    {
        public Song(string type, string name, string time)
        {
            this.Type = type;
            this.Name = name;
            this.Time = time;
        }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> allSongs = new List<Song>();
            int numOfSongs = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfSongs; i++)
            {
                string[] songArgs = Console.ReadLine().Split("_");
                string type = songArgs[0];
                string name = songArgs[1];
                string time = songArgs[2];

                Song newSong = new Song(type, name, time);
                allSongs.Add(newSong);
            }

            string wantedSongs = Console.ReadLine();
            if(wantedSongs == "all")
            {
                foreach (Song song in allSongs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in allSongs)
                {
                    if (song.Type == wantedSongs)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
}
