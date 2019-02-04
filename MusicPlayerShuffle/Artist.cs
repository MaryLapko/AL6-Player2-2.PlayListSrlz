using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    public class Artist { 
    
        public enum Genre
        {
            Rock,
            Classic,
            Trans,
            Techno,
            DubStep
        }
       
        public string Name;
        public Genre ArtistGenre;

        public Artist()
        {
            this.Name = "Default artist";           
        }

        public Artist(string name)
        {
            this.Name = name;            
        }

        public Artist(string name, Genre genre)
        {
            this.Name = name;
            this.ArtistGenre = genre;
        }
    }
}
