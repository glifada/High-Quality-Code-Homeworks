using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    class GenericList<T> 
        where T:IComparable
    {
        private T[] elements;
        private int count;
        private int capacity;

        public GenericList(int capacity)
        {
            this.elements = new T[this.capacity];
            this.capacity = capacity;
        }

        public T[] Elements { get; set; }

        public int Count { get; set; }
        public int Capacity { get; set; }

        // Add element
        public void Add (T item)
        {
            if (this.Count == this.Capacity)
            {
                this.DoubleSize();
            }
            this.Elements[this.Count] = item;
            this.Count++;
        }

        // Access element by index
        public T this[int index]
        {
            get
            {
                return this.Elements[index];
            }
            set
            {
                if (index < 0 || this.Count <= index)
                {
                    throw new ArgumentOutOfRangeException("The index is out of range!");
                }
                this.Elements[index] = value;
            }
        }

        // Remove element by index
        public void RemoveAt(int index)
        {
            if (index < 0 || this.Count <= index)
                {
                    throw new ArgumentOutOfRangeException("The index is out of range!");
                }
            T[] temp = new T[this.Count];
            Array.Copy(this.Elements, temp, this.Count);
            for (int i = index; i < this.Count; i++)
            {
                temp[i] = temp[i + 1];
            }
            this.Count--;
            this.Elements = new T[this.Count];
            Array.Copy(temp, this.Elements, this.Count);
        }

        // Insert element at given position
        public void InsertAt(T item, int index)
        {
            if (index < 0 || this.Count <= index)
            {
                throw new ArgumentOutOfRangeException("The index is out of range!");
            }
            if (index == this.Count)
            {
                this.Add(item);
            }
            else
            {
                this.Count++;
                T[] temp = new T[this.Count];
                Array.Copy(this.Elements, temp, this.Count);
                for (int i = index + 1; i < this.Count - 1; i++)
                {
                    temp[i] = temp[i - 1];
                }
                temp[index] = item;
                this.Elements = new T[this.Count];
                Array.Copy(temp, this.Elements, this.Count);
            }
        }

        // Clear the list
        public void ClearList()
        {
            this.Capacity = 0;
            this.Elements = new T[this.Capacity];
            this.Count = 0;
        }

        //Find element by its value
        public int IndexOf(T item)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.Elements[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        // ToString()
        public override string ToString()
        {
            return string.Format(string.Join(", ", this.Elements));
        }

        // Auto-grow
        public void DoubleSize()
        {
            T[] temp = new T[this.Count];
            Array.Copy(this.Elements, temp, this.Count);
            this.Capacity = 2 * this.Capacity;
            this.Elements = new T[this.Capacity];
            Array.Copy(temp, this.Elements, this.Count);
        }

        // Find minimal element
        public T Min()
        {
            T min = this.Elements[0];
            for (int i = 0; i < this.Count; i++)
            {
                if (this.Elements[i].CompareTo(min) < 0)
                {
                    min = this.Elements[i];
                }
            }
            return min;
        }

        // Find maximal element
        public T Max()
        {
            T max = this.Elements[0];
            for (int i = 0; i < this.Count; i++)
            {
                if (this.Elements[i].CompareTo(max) > 0)
                {
                    max = this.Elements[i];
                }
            }
            return max;
        }
    }
}
