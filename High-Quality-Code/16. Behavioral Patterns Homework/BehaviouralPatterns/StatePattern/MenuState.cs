using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class MenuState : DVDPlayerState
    {
        public MenuState()
        {
            Console.WriteLine("MENU");
        }

        public override void PlayButtonPressed(DVDPlayer player)
        {
            Console.WriteLine("  Next Menu Item Selected");
        }

        public override void MenuButtonPressed(DVDPlayer player)
        {
            player.State = new StandbyState();
        }
    }
}
