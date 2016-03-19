using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMaze
{
    public class Player
    {

        //private string _NickName;

        public int Id { get; set; }

        //public String NickName { 
        //    get { return _NickName; } 
        //    set 
        //    {
        //        _NickName = value;
        //        OnPropertyChanged("NickName");
        //    }
        //}

        public string NickName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Score { get; set; }
        //public int Rating { get; set; }

        //public event PropertyChangedEventHandler PropertyChanged;

        //private void OnPropertyChanged(string p)
        //{
        //    throw new NotImplementedException();
        //}

    }
}
