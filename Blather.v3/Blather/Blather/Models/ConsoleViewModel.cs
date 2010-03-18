using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Blather.Core.Helpers;
using System.ComponentModel;
using System.Windows;

namespace Blather.Models
{
    public class ConsoleViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the ConsoleViewModel class.
        /// </summary>
        public ConsoleViewModel()
        {
			_ImageSource = new System.Windows.Controls.Image();
        }

		private string _SomeString;
		public string SomeString
		{
			get { return _SomeString; }
			set
			{
				_SomeString = value;
			}
		}
        

        private System.Windows.Controls.Image _ImageSource;
        public System.Windows.Controls.Image ImageSource
        {
            get
            {
                return _ImageSource;
            }
            set
            {
                _ImageSource = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Bitmap"));
                }
            }
        }

		public void SetImage(Bitmap bitmap)
		{
			ImageSource.Source = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(bitmap.GetHbitmap(), IntPtr.Zero, Int32Rect.Empty, System.Windows.Media.Imaging.BitmapSizeOptions.FromEmptyOptions());
		}

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
