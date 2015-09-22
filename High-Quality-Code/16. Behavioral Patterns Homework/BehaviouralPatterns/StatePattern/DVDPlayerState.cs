using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public abstract class DVDPlayerState
    {
        public abstract void PlayButtonPressed(DVDPlayer player);

        public abstract void MenuButtonPressed(DVDPlayer player);
    }
}
