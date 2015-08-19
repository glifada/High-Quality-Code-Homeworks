using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _07.Timer
{
    public delegate void TimerDelegate();
    class Timer
    {
        private int interval;
        private TimerDelegate seconds;

        public Timer(int interval)
        {
            this.Interval = interval;
            this.Seconds = new TimerDelegate(TimerMethod);
        }

        public int Interval 
        {
            get { return this.interval; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("The interval must be a positive value!");
                }
                this.interval = value;
            }
        }

        public TimerDelegate Seconds { get; set; }

        public static void TimerMethod()
        {
            Console.WriteLine("The time is {0}", DateTime.Now.ToLongTimeString());
        }

        public void StartTimer()
        {
            while (true)
            {
                this.Seconds();
                Thread.Sleep(this.Interval * 1000);
            }
        }
    }
}
