using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class StatePattern
    {
        static void Main()
        {
            var player = new DVDPlayer();

            player.PressPlayButton();
            player.PressMenuButton();
            player.PressPlayButton();
            player.PressPlayButton();
            player.PressMenuButton();
            player.PressPlayButton();
            player.PressPlayButton();
        }
    }
}
