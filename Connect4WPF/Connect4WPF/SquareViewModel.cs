﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4WPF
{
    enum TypeToken { TOKEN_RED = 1, TOKEN_BLACK = 0, TOKEN_NONE = -1 };
    
    public class SquareViewModel : INotifyPropertyChanged
    {
        private int _Token;
        public int Token
        {
            get
            {
                return _Token;
            }
            set
            {
              //  if (_Token.Equals(value)) return;
                if (_Token == value) return;// cambiado by Isaac
                _Token = value;
                RaisePropertyChanged("Token");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string property)
        {
            var handlers = PropertyChanged;
            if (handlers != null)
            {
                var args = new PropertyChangedEventArgs(property);
                handlers(this, args);
            }
        }
    }
}
