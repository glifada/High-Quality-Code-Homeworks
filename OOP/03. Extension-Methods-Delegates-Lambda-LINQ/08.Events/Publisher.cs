using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Events
{
    class Publisher
    {
        public delegate void CustomEventHandler(object sender, TestEvent e);

        public event CustomEventHandler RaiseCustomEvent;

        public void RaiseSampleEvent()
        {
            Console.WriteLine("An event will be raised");
            OnRaiseCustomEvent(new TestEvent("This is the test event"));
        }

        protected virtual void OnRaiseCustomEvent(TestEvent e)
        {
            CustomEventHandler handler = RaiseCustomEvent;

            if (handler != null)
            {
                e.TestMessage += String.Format(" at {0}", DateTime.Now);

                handler(this, e);
            }
        }
    }
}
