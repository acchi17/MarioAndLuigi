using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioAndLuigi.Objects
{
    public abstract class CharaBase
    {
        public CharaBase(int x, int y, Color color)
        {
            X = x;
            Y = y;
            Color = color;  
        }

        public int X { get; set; }
        public int Y { get; set; }
        public Color Color { get; set; }

        public abstract void Right();
        public abstract bool IsMessageExist();
        public abstract string GetMessage();
    }
}
