using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matrix
{
    public class CurrentPosition
    {
        private int x;
        private int y;
        public CurrentPosition(int startX, int startY)
        {
            this.X = startX;
            this.Y = startY;
        }
        public int X
        {
            get { return this.x; }
            set
            {
                if (value < 0 || 99 < value)
                {
                    throw new ArgumentOutOfRangeException("X must be positive integer number less than 100");
                }
                this.x = value;
            }
        }
        public int Y
        {
            get { return this.y; }
            set
            {
                if (value < 0 || 99 < value)
                {
                    throw new ArgumentOutOfRangeException("Y must be positive integer number less than 100");
                }
                this.y = value;
            }
        }
    }
}
