using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioAndLuigi.Objects
{
    public sealed class Mario : CharaBase
    {
        private int _count = 0;

        public Mario() : base(10, 10, Color.Red)
        {

        }

        public override void Right()
        {
            base.X += 10;
        }

        public override bool IsMessageExist()
        {
            _count++;
            if(_count >= 3)
            {
                _count = 0;
                return true;
            }
            return false;
        }

        public override string GetMessage()
        {
            return "My name is Mario";
        }
    }
}
