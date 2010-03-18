using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Blather.Core.Helpers;
using System.ComponentModel;

namespace Blather.Models
{
    public class ConsoleViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the ConsoleViewModel class.
        /// </summary>
        public ConsoleViewModel()
        {
        }

        private Bitmap _Bitmap;
        public Bitmap Bitmap
        {
            get
            {
                return _Bitmap;
            }
            set
            {
                _Bitmap = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Bitmap"));
                }
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
