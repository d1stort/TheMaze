using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TheMaze.ViewModels;

namespace TheMaze.Commands
{
    internal class PlayerRegisterCommand : ICommand
    {
        public PlayerRegisterCommand(PlayerViewModel playerViewModel)
        {
            _PlayerViewModel = playerViewModel;
        }

        private PlayerViewModel _PlayerViewModel;


        public bool CanExecute(object parameter)
        {
            return _PlayerViewModel.CanRegister;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value;  }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            _PlayerViewModel.SaveChanges();
        }
    }
}
