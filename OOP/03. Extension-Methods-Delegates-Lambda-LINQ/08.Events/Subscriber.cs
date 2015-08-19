using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Events
{
    class Subscriber
    {
        private string name;

        public Subscriber(string name, Publisher pub)
        {
            this.Name = name;

            pub.RaiseCustomEvent += HandleCustomEvent;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        void HandleCustomEvent(object sender, TestEvent e)
        {
            Console.WriteLine("The event is handled!");
            Console.WriteLine(this.name + " received a message: {0}", e.TestMessage);
        }
    }
}
