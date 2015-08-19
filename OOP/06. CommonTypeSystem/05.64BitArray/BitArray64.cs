using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._64BitArray
{
    class BitArray64 : IEnumerable<int>
    {
        private ulong number;

        public BitArray64()
        {
        }

        public ulong Number { get; set; }

        public override bool Equals(object obj)
        {
            return this.Number.Equals(obj);
        }

        public override int GetHashCode()
        {
            return this.Number.GetHashCode();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            for (int i = 0; i < 64; i++)
            {
                if (((this.Number >> (63 - i)) & 1) == 1)
                {
                    sb.Append(1);
                }
                else
                {
                    sb.Append(0);
                }
            }

            return sb.ToString();
        }

        public int this[int index]
        {
            get
            {
                return (int)((this.Number >> index) & 1);
            }

            set
            {
                if (index < 0 || index > 63)
                {
                    throw new ArgumentOutOfRangeException("Index is out of range!");
                }
                if (value < 0 || value > 1)
                {
                    throw new ArgumentException("Value must be 0 or 1");
                }
                if (value == 1)
                {
                    this.Number = this.Number | ((ulong)1 << index);
                }
                else
                {
                    this.Number = this.Number & (~((ulong)1 << index));
                }
            }
        }

        public static bool operator ==(BitArray64 firstNumber, BitArray64 secondNumber)
        {
            return firstNumber == secondNumber;
        }

        public static bool operator !=(BitArray64 firstNumber, BitArray64 secondNumber)
        {
            return firstNumber != secondNumber;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this[i];
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
