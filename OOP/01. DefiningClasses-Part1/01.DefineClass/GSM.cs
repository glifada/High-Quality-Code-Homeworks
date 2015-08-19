using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClass
{
    public class GSM
    {
        private string manufacturer;
        private string model;
        private double price;
        private string owner;
        private Battery battery;
        private Display display;
        private static string iPhone4S = "Info for IPhone 4S";
        private static List<Calls> callHistory = new List<Calls> ();

        public GSM(string manufacturer, string model, string owner = null, double price = 0, Battery battery = null, Display display = null)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.owner = owner;
            this.price = price;
            this.battery = battery;
            this.display = display;
        }

        public string Manufacturer 
        {
            get 
            {
                return this.manufacturer;
            }
        }
        public string Model 
        {
            get
            {
                return this.model;
            }
        }
        public double Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The price must be non-negative value!");
                }
                else
                {
                    this.price = value;
                }
            }
        }
        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }
        public Battery Battery 
        {
            get { return this.battery; }
            set { this.battery = value; }
        }
        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }
        public static string IPhone4S 
        {
            get { return GSM.iPhone4S; }
        }
        public static List<Calls> CallHistory 
        {
            get { return GSM.callHistory; }
        }

        public override string ToString ()
        {
            return "GSM:" + " " + this.manufacturer + ", " + this.model;
        }

        public List<Calls> AddCall (Calls call)
        {
            GSM.CallHistory.Add(call);
            return GSM.CallHistory;
        }
        
        public List<Calls> DeleteCall(Calls call)
        {
            GSM.callHistory.Remove(call);
            return GSM.CallHistory;
        }

        public void ClearCallHistory()
        {
            GSM.callHistory.Clear();
        }

        public static double CalculateTotalPrice (double pricePerMinute)
        {
            double totalPrice = 0;
            int totalDuration = 0;
            foreach (Calls call in GSM.CallHistory)
            {
                totalDuration += call.Duration;
            }
            totalPrice = (totalDuration / 60.0) * pricePerMinute;
            return totalPrice;
        }
    }
}
