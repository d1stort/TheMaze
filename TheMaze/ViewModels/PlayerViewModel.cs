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
    class PlayerViewModel
    {
        private Player _Player;

        public PlayerViewModel()
        {
            _Player = new Player();
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

        private void AddScore(int points)
        {
            _Player.Score += points;
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

        public void Update()
        {
            AddScore(100);
        }

        public void SaveChanges ()
        {
            Player.NickName = "";
        }


        public bool CanRegister 
        {
            get
            {
                if (Player == null)
                    return false;
                return String.IsNullOrWhiteSpace(Player.NickName);
            }
        
        }

    }
}
