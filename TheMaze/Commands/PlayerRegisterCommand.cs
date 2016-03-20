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
            _ViewModel = playerViewModel;
        }

        private PlayerViewModel _ViewModel;

        //Этот метод даёт понять кнопке registerButton, когда быть активной, а когда нет
        public bool CanExecute(object parameter)
        {
            return _ViewModel.CanRegister;
        }

        //Эта штуковина даёт возможность командам обрабатывать происходящее в окнах впф
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value;  }
            remove { CommandManager.RequerySuggested -= value; }
        }

        //Ну и тут изменённое имя игрока сохраняется (нет)
        public void Execute(object parameter)
        {
            _ViewModel.SaveChanges();
        }
    }
}
