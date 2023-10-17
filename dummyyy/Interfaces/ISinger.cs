using dummyyy.Classes;
using System;


namespace dummyyy.Interfaces
{
    internal interface ISinger
    {
        public string SingerName { get; set; }
        public string SingerSurname { get; set; }

        public void Sing(Song song)
        {
            Console.WriteLine($"Singer {this.SingerName} is now singing {song.SongName}");
        }

    }
}
