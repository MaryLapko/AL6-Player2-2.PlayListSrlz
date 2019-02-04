using MusicPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerShuffle
{
    class ColorSkin : ISkin
    {
        public ConsoleColor Color;      
        public ColorSkin(ConsoleColor color)
        {
            Color = color;
        }
        //public override void NewScreen()
         public void NewScreen()
        {
            Console.Clear();
        }

        //public override void Render(string text) 
        public void Render(string text)
        {
            Console.ForegroundColor = Color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
