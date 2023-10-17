using dummyyy.Classes;
using System;


namespace dummyyy.Interfaces
{
    internal interface IAlbum
    {
        public string AlbumName {  get; set; }   
        public void AddSong(Song song);
       
    }
}
