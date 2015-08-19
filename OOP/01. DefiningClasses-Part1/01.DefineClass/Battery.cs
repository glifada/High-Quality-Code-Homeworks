using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClass
{
    public enum BatteryType
    {
        LiIon, NiMH, NiCd
    }

    public class Battery
    {
        private string model;
        private double hoursIdle;
        private double hoursTalk;
        private BatteryType batteryType;

        public Battery(BatteryType batteryType, string model = null, double hoursIdle = 0, double hoursTalk = 0)
        {
            this.batteryType = batteryType;
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }

        public BatteryType BatteryType 
        {
            get { return this.batteryType; }
            set { this.batteryType = value; }
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public double HoursIdle
        {
            get { return this.hoursIdle; }
            set 
            {
                if (value > 0)
                {
                    this.hoursIdle = value;                     
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The idle hours must be positive value!");
                }
            }
        }
        public double HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value > 0)
                {
                    this.hoursTalk = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The talk hours must be positive value!");
                }
            }
        }

    }
}
