using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TheMaze.Commands;

namespace TheMaze.ViewModels
{
    class PlayerViewModel : INotifyPropertyChanged
    {
        private Player _Player;

        public PlayerViewModel()
        {
            _Player = new Player() { Id = 1, NickName = "AAA" };
            RegisterCommand = new PlayerRegisterCommand(this);
            UpdateCommand = new PlayerUpdateCommand(this);
        }

        public Player Player
        {
            get
            {
                return _Player;
            }
        }

        public ICommand RegisterCommand
        {
            get;
            private set;
        }

        public ICommand UpdateCommand
        {
            get;
            private set;
        }

        public void SaveChanges ()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        public bool CanRegister 
        {
            get
            {
                if (Player == null)
                    return false;
                return !String.IsNullOrWhiteSpace(Player.NickName);
            }
        
        }
    }
}
