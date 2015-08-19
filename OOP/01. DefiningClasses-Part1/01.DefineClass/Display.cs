using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClass
{
    public class Display
    {
        private double displaySize;
        private int numberOfColors;

        public Display(double displaySize = 0, int numberOfColors = 0)
        {
            this.displaySize = displaySize;
            this.numberOfColors = numberOfColors;
        }

        public double DisplaySize
        {
            get { return this.displaySize; }
            set 
            {
                if (value > 0)
                {
                    this.displaySize = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The size of display must be positive value!");
                }
            }
        }
        public int NumberOfColors
        {
            get { return this.numberOfColors; }
            set
            {
                if (value > 0)
                {
                    this.numberOfColors = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The number of colors must be positive value!");
                }
            }
        }
    }
}
