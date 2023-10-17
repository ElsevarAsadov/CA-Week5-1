using dummyyy.Interfaces;
using System;


namespace dummyyy.Classes
{
    internal class Song : Singer, ISong
    {
        public string SongName { get; set; } 
        public string SongPublishDate { get; set; }


        public Song(string songName, string singerName, string singerSurname) : base(singerName, singerSurname) {

            this.SongName = songName;
        }
    }
}
