using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Timer
{
    class TimerMain
    {
        static void Main()
        {
            Timer timer = new Timer(10);
            timer.StartTimer();
        }
    }
}
