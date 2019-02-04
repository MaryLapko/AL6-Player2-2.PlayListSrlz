using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerShuffle
{
    //public abstract class Skin
    //{
    //    public abstract void NewScreen();
    //    public abstract void Render(string text);
    //}

    public interface ISkin
    {
        void NewScreen();
        void Render(string text);
    }

}
