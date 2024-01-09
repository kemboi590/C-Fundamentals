
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class_Attributes
{
    internal class Song
    {
        public string title;
        public string artist;
        public int duration;
        public static int SongCount = 0;

        public Song(string title, string artist, int duration) 
        {
            this.title = title;
            this.artist = artist;
            this.duration = duration;
            SongCount++;
        }

        //this method can then be accessed by the instances og the class
        public int getSongCount()
        {
            return SongCount;
        }
    }
}
