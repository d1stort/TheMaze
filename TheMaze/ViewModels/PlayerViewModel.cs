using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TheMaze.ViewModels
{
    class PlayerViewModel
    {
        private Player _Player;

        public PlayerViewModel()
        {
            _Player = new Player();
        }

        public Player Player
        {
            get
            {
                return _Player;
            }
        }

    }
}
