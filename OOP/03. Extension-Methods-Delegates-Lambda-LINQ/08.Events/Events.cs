using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Events
{
    class Events
    {
        static void Main()
        {
            Publisher eventPublisher = new Publisher();
            new Subscriber("Pesho", eventPublisher);
            new Subscriber("Gosho", eventPublisher);

            eventPublisher.RaiseSampleEvent();
        }
    }
}
