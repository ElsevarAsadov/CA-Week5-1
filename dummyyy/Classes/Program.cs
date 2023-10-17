namespace dummyyy.Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Album album = new("Thriller", "Michael", "Jackson");

            album.AddSong(new Song("The Girl is Mine", "Michael", "Jackson"));
            album.AddSong(new Song("Human Nature", "Michael", "Jackson"));
            album.AddSong(new Song("The Lady in My Life", "Michael", "Jackson"));

            album.ShowSongs();

        }
    }
}