﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class DVDPlayer
    {
        private DVDPlayerState _state;

        public DVDPlayer()
        {
            _state = new StandbyState();
        }

        public DVDPlayer(DVDPlayerState state)
        {
            _state = state;
        }

        public void PressPlayButton()
        {
            _state.PlayButtonPressed(this);
        }

        public void PressMenuButton()
        {
            _state.MenuButtonPressed(this);
        }

        public DVDPlayerState State
        {
            get { return _state; }
            set { _state = value; }
        }
    }
}
