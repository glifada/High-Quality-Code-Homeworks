using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matrix
{
    public class CurrentDirection
    {
        private int x;
        private int y;
        public CurrentDirection(int startX, int startY)
        {
            this.X = startX;
            this.Y = startY;
        }
        public int X
        {
            get { return this.x; }
            set
            {
                if (value < -1 || 1 < value)
                {
                    throw new ArgumentOutOfRangeException("Invalid X for CurrentDirection");
                }
                this.x = value;
            }
        }
        public int Y
        {
            get { return this.y; }
            set
            {
                if (value < -1 || 1 < value)
                {
                    throw new ArgumentOutOfRangeException("Invalid Y for CurrentDirection");
                }
                this.y = value;
            }
        }
    }
}
