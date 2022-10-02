using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioAndLuigi.Objects
{
    public sealed class Luigi : CharaBase
    {
        private int _count = 0;

        public Luigi() : base(10, 50, Color.Lime)
        {

        }

        public override void Right()
        {
            base.X += 20;
        }

        public override bool IsMessageExist()
        {
            _count++;
            if (_count >= 5)
            {
                _count = 0;
                return true;
            }
            return false;
        }

        public override string GetMessage()
        {
            return "My name is Luigi";
        }
    }
}
