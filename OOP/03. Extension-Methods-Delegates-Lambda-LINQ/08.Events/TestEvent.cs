using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Events
{
    class TestEvent : EventArgs
    {
        private string testMessage;

        public TestEvent(string text)
        {
            this.TestMessage = text;
        }
        
        public string TestMessage
        {
            get { return this.testMessage; }
            set { this.testMessage = value; }
        } 
    }
}
