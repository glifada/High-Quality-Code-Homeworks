using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RangeExceptions
{
    class InvalidRangeException<T> : ApplicationException
    {
        private T start;
        private T end;

        public InvalidRangeException(string message, T start, T end)
            : base(message)
        {
            this.Start = start;
            this.End = end;
        }

        public InvalidRangeException(string message, Exception ex, T start, T end)
            : base(message, ex)
        {
            this.Start = start;
            this.End = end;
        }

        public T Start 
        {
            get { return this.start; }
            set { this.start = value; }
        }

        public T End
        {
            get { return this.end; }
            set { this.end = value; }
        }
    }
}
