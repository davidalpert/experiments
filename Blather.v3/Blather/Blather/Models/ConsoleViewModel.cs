using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Blather.Core.Helpers;
using System.ComponentModel;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media.Imaging;
using System.IO;
using System.Drawing.Imaging;

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
			var m = new MemoryStream();
			//using (var m = new MemoryStream())
			//{
				bitmap.Save(m, ImageFormat.Png);

				BitmapImage wpfBitmap = new BitmapImage();
				wpfBitmap.BeginInit();
				wpfBitmap.StreamSource = m;
				wpfBitmap.EndInit();

				ImageSource.Source = wpfBitmap;
			//}
		}

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
