using dummyyy.Interfaces;
using System;


namespace dummyyy.Classes
{
    internal class Album : Singer, IAlbum
    {
        public Song[] Songs = Array.Empty<Song>();

        public string AlbumName { get; set; }
        public Album(string albumName, string singerName, string singerSurname) : base(singerName, singerSurname){
            this.AlbumName = albumName; 
        }

        public void AddSong(Song song)
        {
            Console.WriteLine($"Song - {song.SongName} added successfully to {this.AlbumName}");
            Array.Resize(ref this.Songs, this.Songs.Length + 1);
            this.Songs[^1] = song;
        }

        public void ShowSongs()
        {
            
            Console.WriteLine($"\n\n\n---------{this.AlbumName}---------\n\n\n");

            bool found = false;

            foreach(Song song in this.Songs)
            {
                found = true;
                Console.WriteLine("Name - " + " " + song.SongName + " " + song.SongPublishDate);
            }

            if(!found) Console.WriteLine("There is no song yet.");

            Console.WriteLine($"\n\n\n+++++++++++++++++++++++++++++++++++\n\n\n");
        }
    }
    
 }


