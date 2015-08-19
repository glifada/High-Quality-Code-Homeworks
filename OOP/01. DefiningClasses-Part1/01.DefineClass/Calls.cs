using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClass
{
    public class Calls
    {
        private DateTime date;
        private TimeSpan time;
        private string dialedPhone;
        private int duration;

        public Calls(DateTime dateTime, string dialedPhone, int duration)
        {
            this.date = dateTime;
            this.time = dateTime.TimeOfDay;
            this.dialedPhone = dialedPhone;
            this.duration = duration;
        }

        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }
        public TimeSpan Time
        {
            get { return this.time; }
            set { this.time = value; }
        }
        public string DialedPhone
        {
            get 
            {
                foreach (char symbol in this.dialedPhone)
                {
                    if (symbol < '0' || symbol > '9')
                    {
                        throw new ArgumentOutOfRangeException("The number must contains digits only!");
                    }
                }
                return this.dialedPhone;
            }
            set { this.dialedPhone = value; }
        }
        public int Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }
    }
}
