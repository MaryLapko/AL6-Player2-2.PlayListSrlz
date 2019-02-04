using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    [Serializable]

    public class Song:IComparable
    {

        public int Duration;
        public string Name;
        public Artist Artist;
        public Album Album;
        public bool? Like = null;
        public string Path;
        public string Extension;

        public Song()
        {

        }
        //public Song(int duration, string name, bool like, string path, string Extension)
        //{

        //}
        public int CompareTo(object obj)
        {

            if (this.Name == null)
                return 0;
            var songToCompare = (obj as Song);
            return this.Name.CompareTo(songToCompare);

            //return this.Name?.CompareTo((obj as Song))?.Name)??0;
        }
        
        public void LikeMethod()
        {
            Like = true;
        }

        public void DisLikeMethod()
        {
            Like = false;
        }
    }
}
