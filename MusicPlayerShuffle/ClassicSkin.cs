using MusicPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerShuffle
{
    class ClassicSkin : ISkin
    {
        //public override void NewScreen()
        public void NewScreen()
        {
            Console.Clear();
        }

        //public override void Render(string text)
        public void Render(string text)
        {
            Console.WriteLine(text);
        }
    }
}
