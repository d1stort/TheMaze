using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMaze.ViewModels
{
    class PlayerViewModel : INotifyPropertyChanged
    {
        private Player _Player;

        public PlayerViewModel()
        {
            _Player = new Player() { Id = 1, NickName = "AAA" };
        }

        public Player Player
        {
            get
            {
                return _Player;
            }
        }

        public void SaveChanges ()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
