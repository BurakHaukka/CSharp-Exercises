using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T21
{
 // 
    public class CD 
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public int NumberOfSongs { get; set; }
        public int SecLeft { get; set; }
        public int TotalMin { get; set; }

         public void TotalLength() 
        {
            //int minToSec = MinSong * 60;
            //int totalSec = minToSec + SecSong;

            //int totalLenSec = minToSec + totalSec;
            //totalMin = totalLenSec / 60;
            //secLeft = totalLenSec % 60;

            int min = 0;
            int sec = 0;

            foreach (Songs song in Songs)
            {
                min += song.MinSong;
                sec += song.SecSong;
            }
            int final = (min * 60) + sec;

            TotalMin = final / 60;
            SecLeft = final % 60;
        }

        public List<Songs> Songs { get; set; }

        public void CountSongs()
        {
            NumberOfSongs = Songs.Count;
        }

        public CD() 
        {
            Songs = new List<Songs>();
        }

        public string ToString() 
        {
            return $"Album Name: {Name}\nArtist: {Artist}\nGenre: {Genre}\nThere are: {NumberOfSongs} songs\nLength: {TotalMin}:{SecLeft}\n-----------\n Songs:";
        }

        public void PrintSongs() 
        {
            foreach (var item in Songs)
            {
                Console.WriteLine($"{item.Name} {item.MinSong}:{item.SecSong}");
            }
        }

    }

    public class Songs 
    {
        public string Name { get; set; }
        public int MinSong { get; set; }
        public int SecSong { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CD NewAlbum = new CD() {Name = "New Album", Artist = "New Artist", Genre = "Electronic" };
            Songs Song1 = new Songs() { Name = "Song1", MinSong = 1, SecSong = 30};
            Songs Song2 = new Songs() { Name = "Song2", MinSong = 3, SecSong = 45 };
            Songs Song3 = new Songs() { Name = "Song3", MinSong = 4, SecSong = 0 };
            Songs Song4 = new Songs() { Name = "Song4", MinSong = 5, SecSong = 12 };
            Songs Song5 = new Songs() { Name = "Song5", MinSong = 1, SecSong = 34 };
            Songs Song6 = new Songs() { Name = "Song6", MinSong = 2, SecSong = 22 };
            NewAlbum.Songs.Add(Song1);
            NewAlbum.Songs.Add(Song2);
            NewAlbum.Songs.Add(Song3);
            NewAlbum.Songs.Add(Song4);
            NewAlbum.Songs.Add(Song5);
            NewAlbum.Songs.Add(Song6);

            NewAlbum.TotalLength();
            NewAlbum.CountSongs();
            Console.WriteLine(NewAlbum.ToString());
            NewAlbum.PrintSongs();


            

           
        }
    }
}
